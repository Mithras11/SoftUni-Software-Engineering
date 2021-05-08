using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        private ICollection<IComputer> computers;
        private ICollection<IComponent> components;
        private ICollection<IPeripheral> peripherals;


        public Controller()
        {
            this.computers = new List<IComputer>();
            this.components = new List<IComponent>();
            this.peripherals = new List<IPeripheral>();
        }


        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price, double overallPerformance, int generation)
        {
            CheckIfComputerExists(computerId);
            var targetComputer = this.computers.FirstOrDefault(x => x.Id == computerId);

            if (this.components.Any(x => x.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
            }

            IComponent component = null;

            if (componentType == "CentralProcessingUnit")
            {
                component = new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "Motherboard")
            {
                component = new Motherboard(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "PowerSupply")
            {
                component = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "RandomAccessMemory")
            {
                component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "SolidStateDrive")
            {
                component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (componentType == "VideoCard")
            {
                component = new VideoCard(id, manufacturer, model, price, overallPerformance, generation);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComponentType);
            }


            targetComputer.AddComponent(component);
            this.components.Add(component);

            return string.Format(SuccessMessages.AddedComponent, componentType, id, computerId);

        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            if (this.computers.Any(x => x.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComputerId);
            }

            IComputer computer = null;

            if (computerType == "DesktopComputer")
            {
                computer = new DesktopComputer(id, manufacturer, model, price);
            }
            else if (computerType == "Laptop")
            {
                computer = new Laptop(id, manufacturer, model, price);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComputerType);
            }
                      


            this.computers.Add(computer);
            return string.Format(SuccessMessages.AddedComputer, id);

        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
        {
            CheckIfComputerExists(computerId);
            var targetComputer = this.computers.FirstOrDefault(x => x.Id == computerId);

            if (this.peripherals.Any(x => x.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingPeripheralId);
            }

            IPeripheral peripheral = null;

            if (peripheralType == "Headset")
            {
                peripheral = new Headset(id, manufacturer, model, price, overallPerformance, connectionType);
            }
            else if (peripheralType == "Keyboard")
            {
                peripheral = new Keyboard(id, manufacturer, model, price, overallPerformance, connectionType);
            }
            else if (peripheralType == "Monitor")
            {
                peripheral = new Monitor(id, manufacturer, model, price, overallPerformance, connectionType);
            }
            else if (peripheralType == "Mouse")
            {
                peripheral = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidPeripheralType);
            }


            targetComputer.AddPeripheral(peripheral);
            this.peripherals.Add(peripheral);

            return string.Format(SuccessMessages.AddedPeripheral, peripheralType, id, computerId);

        }

        public string BuyBest(decimal budget)
        {
            if (this.computers.Count == 0 || this.computers.Any(x => x.Price <= budget) == false)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CanNotBuyComputer, budget));
            }

            //this.computers = computers.OrderByDescending(x => x.OverallPerformance).ToList();
            this.computers = computers.OrderByDescending(x => x.OverallPerformance).ThenByDescending(x => x.Price).ToList();

            //var targetComputer = computers.FirstOrDefault(x => x.Price <= budget);
            var targetComputer = computers.FirstOrDefault();


            this.computers.Remove(targetComputer);
            return targetComputer.ToString();
        }

        public string BuyComputer(int id)
        {
            CheckIfComputerExists(id);
            var targetComputer = this.computers.FirstOrDefault(x => x.Id == id);

            this.computers.Remove(targetComputer);

            return targetComputer.ToString();
        }

        public string GetComputerData(int id)
        {
            CheckIfComputerExists(id);
            var targetComputer = this.computers.FirstOrDefault(x => x.Id == id);

            return targetComputer.ToString();
        }

        public string RemoveComponent(string componentType, int computerId)
        {
            CheckIfComputerExists(computerId);
            var targetComputer = this.computers.FirstOrDefault(x => x.Id == computerId);

            if (targetComputer.Components.Any(x => x.GetType().Name == componentType) == false)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingComponent, componentType, targetComputer.GetType().Name, computerId));
            }

            var targetComponent = targetComputer.Components.FirstOrDefault(x => x.GetType().Name == componentType);

            targetComputer.RemoveComponent(componentType);
            this.components.Remove(targetComponent);

            return string.Format(SuccessMessages.RemovedComponent, componentType, targetComponent.Id);


        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            CheckIfComputerExists(computerId);
            var targetComputer = this.computers.FirstOrDefault(x => x.Id == computerId);

            if (targetComputer.Peripherals.Any(x => x.GetType().Name == peripheralType) == false)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingPeripheral, peripheralType, targetComputer.GetType().Name, computerId));
            }

            var targetPeripheral = targetComputer.Peripherals.FirstOrDefault(x => x.GetType().Name == peripheralType);

            targetComputer.RemovePeripheral(peripheralType);
            this.peripherals.Remove(targetPeripheral);

            return string.Format(SuccessMessages.RemovedPeripheral, peripheralType, targetPeripheral.Id);

        }



        private void CheckIfComputerExists(int computerId)
        {
            if (this.computers.Any(x => x.Id == computerId) == false)
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }
        }
    }
}
