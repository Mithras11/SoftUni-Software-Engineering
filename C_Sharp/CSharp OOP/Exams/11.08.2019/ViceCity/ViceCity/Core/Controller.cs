using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Core.Contracts;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Core
{
    public class Controller : IController
    {
        private IPlayer mainPlayer;
        private List<IPlayer> civilPlayers;
        private List<IGun> guns;
        private GangNeighbourhood gangNeighbourhood;

        public Controller()
        {
            this.mainPlayer = new MainPlayer();
            this.civilPlayers = new List<IPlayer>();
            this.guns = new List<IGun>();
            this.gangNeighbourhood = new GangNeighbourhood();
        }

        public string AddGun(string type, string name)
        {
            Gun gun;

            if (type == "Pistol")
            {
                gun = new Pistol(name);
            }
            else if (type == "Rifle")
            {
                gun = new Rifle(name);
            }
            else
            {
                return "Invalid gun type!";
            }

            this.guns.Add(gun);

            return $"Successfully added {name} of type: {type}";

        }

        public string AddGunToPlayer(string name)
        {
            if (this.guns.Count == 0)
            {
                return "There are no guns in the queue!";
            }

            var gun = this.guns.First();

            if (name == "Vercetti")
            {
                this.mainPlayer.GunRepository.Add(gun);
                this.guns.Remove(gun);

                return $"Successfully added {gun.Name} to the Main Player: Tommy Vercetti";
            }

            if (this.civilPlayers.Any(x => x.Name == name) == false)
            {
                return $"Civil player with that name doesn't exists!";
            }

            var civilPlayer = this.civilPlayers.FirstOrDefault(x => x.Name == name);
            civilPlayer.GunRepository.Add(gun);

            this.guns.Remove(gun);

            return $"Successfully added {gun.Name} to the Civil Player: {civilPlayer.Name}";
        }

        public string AddPlayer(string name)
        {
            var civilPlayer = new CivilPlayer(name);
            this.civilPlayers.Add(civilPlayer);

            return $"Successfully added civil player: {civilPlayer.Name}!";
        }

        public string Fight()
        {
            var mainPlayerHealth = this.mainPlayer.LifePoints;
            var civilPlayersHealth = this.civilPlayers.Sum(x => x.LifePoints);
            var initialCivilCount = this.civilPlayers.Count;


            this.gangNeighbourhood.Action(mainPlayer, civilPlayers);

            if (mainPlayer.LifePoints == mainPlayerHealth
                && civilPlayersHealth == civilPlayers.Sum(x => x.LifePoints))
            {
                return $"Everything is okay!";
            }
            else
            {
                var sb = new StringBuilder();

                sb.AppendLine("A fight happened:")
                    .AppendLine($"Tommy live points: {mainPlayer.LifePoints}!")
                    .AppendLine($"Tommy has killed: {initialCivilCount - this.civilPlayers.Count} players!")
                    .AppendLine($"Left Civil Players: {civilPlayers.Count}!");

                return sb.ToString().TrimEnd();
            }
        }
    }
}
