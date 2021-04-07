using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private ICollection<IComponent> components;
        private ICollection<IPeripheral> peripherals;



        protected Computer(int id, string manufacturer, string model, decimal price, double overallPerformance)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.components = new List<IComponent>();
            this.peripherals = new List<IPeripheral>();
        }




        public IReadOnlyCollection<IComponent> Components => this.components.ToList().AsReadOnly();

        public IReadOnlyCollection<IPeripheral> Peripherals => this.peripherals.ToList().AsReadOnly();

        public override decimal Price => base.Price + this.Components.Sum(x => x.Price) + this.Peripherals.Sum(x => x.Price);

        public override double OverallPerformance
        {
            get
            {
                if (this.Components.Count == 0)
                {
                    return base.OverallPerformance;
                }

                return base.OverallPerformance + this.Components.Average(x => x.OverallPerformance);
            }
        }




        public void AddComponent(IComponent component)
        {
            if (this.Components.Any(x => x.GetType().Name == component.GetType().Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingComponent, component.GetType().Name, this.GetType().Name, this.Id));
            }

            this.components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (this.Peripherals.Any(x => x.GetType().Name == peripheral.GetType().Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingPeripheral, peripheral.GetType().Name, this.GetType().Name, this.Id));
            }

            this.peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            if (this.Components.Count == 0
                || (this.Components.Any(x => x.GetType().Name == componentType) == false))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingComponent, componentType, this.GetType().Name, this.Id));
            }

            var targetComponent = this.Components.FirstOrDefault(x => x.GetType().Name == componentType);
            this.components.Remove(targetComponent);

            return targetComponent;

        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            if (this.Peripherals.Count == 0
                || (this.Peripherals.Any(x => x.GetType().Name == peripheralType) == false))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingPeripheral, peripheralType, this.GetType().Name, this.Id));
            }

            var targetPeripheral = this.Peripherals.FirstOrDefault(x => x.GetType().Name == peripheralType);
            this.peripherals.Remove(targetPeripheral);

            return targetPeripheral;

        }



        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            //sb.AppendLine(string.Format(SuccessMessages.ComputerComponentsToString, this.Components.Count));
            sb.AppendLine($" Components ({this.components.Count}):");


            foreach (var item in this.Components)
            {
                sb.AppendLine($"  {item.ToString()}");
            }

            double averageOverallPerformanceOfPeripherals = 0;

            if (this.Peripherals.Any())
            {
                averageOverallPerformanceOfPeripherals = this.Peripherals.Average(x => x.OverallPerformance);
            }

            //sb.AppendLine(string.Format(SuccessMessages.ComputerPeripheralsToString, this.Peripherals.Count, averageOverallPerformanceOfPeripherals));
            sb.AppendLine($" Peripherals ({this.peripherals.Count}); Average Overall Performance ({averageOverallPerformanceOfPeripherals:F2}):");

            foreach (var item in this.Peripherals)
            {
                sb.AppendLine($"  {item.ToString()}");
            }

            return sb.ToString().TrimEnd();



        }
    }
}
