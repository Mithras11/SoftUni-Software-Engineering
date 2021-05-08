using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Repositories.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private IRepository<IDecoration> decorations;
        private ICollection<IAquarium> aquariums;

        public Controller()
        {
            this.decorations = new DecorationRepository();
            this.aquariums = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium = null;

            if (aquariumType == "FreshwaterAquarium")
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else if (aquariumType == "SaltwaterAquarium")
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }

            this.aquariums.Add(aquarium);
            return string.Format(OutputMessages.SuccessfullyAdded, aquariumType);


        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decoration = null;

            if (decorationType == "Ornament")
            {
                decoration = new Ornament();
            }
            else if (decorationType == "Plant")
            {
                decoration = new Plant();
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }

            this.decorations.Add(decoration);
            return string.Format(OutputMessages.SuccessfullyAdded, decorationType);

        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            Fish fish = null;

            if (fishType == "FreshwaterFish")
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);
            }
            else if (fishType == "SaltwaterFish")
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }

            var aquarium = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);

            if (fish.SuitableAquarium != aquarium.GetType().Name)//?!
            {
                return OutputMessages.UnsuitableWater;
            }

            aquarium.AddFish(fish);
            return string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);


        }

        public string CalculateValue(string aquariumName)
        {
            var aquarium = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);

            var result = aquarium.Fish.Sum(x => x.Price) + aquarium.Decorations.Sum(x => x.Price);

            return $"The value of Aquarium {aquariumName} is {result:F2}.";


        }

        public string FeedFish(string aquariumName)
        {
            var aquarium = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);
            aquarium.Feed();

            return string.Format(OutputMessages.FishFed, aquarium.Fish.Count);

        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            var decoration = this.decorations.FindByType(decorationType);

            if (decoration == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentDecoration, decorationType));
            }

            var aquarium = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);

            aquarium.AddDecoration(decoration);
            this.decorations.Remove(decoration);

            return string.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
        }

        public string Report()
        {
            var sb = new StringBuilder();

            foreach (var aquarium in aquariums)
            {
                sb.AppendLine(aquarium.GetInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
