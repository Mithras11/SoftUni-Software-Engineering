  
using EasterRaces.Core.Contracts;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Repositories;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Repositories.Entities;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Core.Contracts
{
    public class ChampionshipController : IChampionshipController
    {
        private readonly DriverRepository driversRepository;
        private readonly CarRepository carsRepository;
        private readonly RaceRepository raceRepository;

        public ChampionshipController()
        {
            driversRepository = new DriverRepository();
            carsRepository = new CarRepository();
            raceRepository = new RaceRepository();
        }
        

        public string AddCarToDriver(string driverName, string carModel)//мой
        {
            bool isCarFound = false;
            bool isDriverFound = false;

            ICar targerCar = null;
            IDriver targerDriver = null;

            if (this.carsRepository.GetByName(carModel) != null)
            {
                isCarFound = true;
            }
            if (this.driversRepository.GetByName(driverName) != null)
            {
                isDriverFound = true;
            }

            string message = string.Empty;

            if (isCarFound == false)
            {
                throw new InvalidOperationException($"Car {carModel} could not be found.");
            }
            else if (isDriverFound == false)
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");

            }
            else if (isCarFound && isDriverFound)
            {
                targerCar = this.carsRepository.GetAll().FirstOrDefault(c => c.Model == carModel);
                targerDriver = this.driversRepository.GetAll().FirstOrDefault(c => c.Name == driverName);

                targerDriver.AddCar(targerCar);
                message = $"Driver {driverName} received car {carModel}.";
            }

            return message;
        }

       

        public string AddDriverToRace(string raceName, string driverName)
        {
            bool isRaceFound = false;
            bool isDriverFound = false;

            IRace targerRace = null;
            IDriver targerDriver = null;

            if (this.raceRepository.GetByName(raceName) != null)
            {
                isRaceFound = true;
            }
            if (this.driversRepository.GetByName(driverName) != null)
            {
                isDriverFound = true;
            }

            string message = string.Empty;

            if (isRaceFound == false)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }
            else if (isDriverFound == false)
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");

            }
            else if (isRaceFound && isDriverFound)
            {
                targerRace = this.raceRepository.GetAll().FirstOrDefault(c => c.Name == raceName);
                targerDriver = this.driversRepository.GetAll().FirstOrDefault(c => c.Name == driverName);

                targerRace.AddDriver(targerDriver);
                message = $"Driver {driverName} added in {raceName} race.";
            }

            return message;
        }


        public string CreateCar(string type, string model, int horsePower)
        {

            if (this.carsRepository.GetByName(model) != null)
            {
                throw new ArgumentException($"Car {model} is already created.");
            }

            Car car = null;

            if (type == "Muscle")
            {
                car = new MuscleCar(model, horsePower);
            }
            else if (type == "Sports")
            {
                car = new SportsCar(model, horsePower);
            }

            this.carsRepository.Add(car);

            

            return $"{car.GetType().Name} {model} is created.";

        }


        public string CreateDriver(string driverName)
        {
            var driver = new Driver(driverName);

            if (this.driversRepository.GetByName(driverName) != null)
            {
                throw new ArgumentException($"Driver {driverName} is already created.");
            }

            driversRepository.Add(driver);

            return $"Driver {driverName} is created.";

        }
        public string CreateRace(string name, int laps)
        {
            var race = new Race(name, laps);

            if (this.raceRepository.GetByName(name) != null)
            {
                throw new InvalidOperationException($"Race {name} is already create.");
            }

            this.raceRepository.Add(race);

            return $"Race {name} is created.";
        }

        public string StartRace(string raceName)
        {

            if (this.raceRepository.GetByName(raceName) == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }

            var currentRace = this.raceRepository.GetByName(raceName);

            if (currentRace.Drivers.Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
            }

            var fastestDrivers = this.driversRepository.GetAll().OrderByDescending(d => d.Car.CalculateRacePoints(currentRace.Laps)).ToList();


            var firstDriversName = fastestDrivers[0].Name;
            var secondDriversName = fastestDrivers[1].Name;
            var thirdDriversName = fastestDrivers[2].Name;

            var sb = new StringBuilder();

            sb.AppendLine($"Driver {firstDriversName} wins {raceName} race.");
            sb.AppendLine($"Driver {secondDriversName} is second in {raceName} race.");
            sb.AppendLine($"Driver {thirdDriversName} is third in {raceName} race.");

            raceRepository.Remove(currentRace);


            return sb.ToString().TrimEnd();
        }
    }
}
 