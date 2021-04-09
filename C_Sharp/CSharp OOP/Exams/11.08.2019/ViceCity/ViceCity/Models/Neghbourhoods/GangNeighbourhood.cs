using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Neghbourhoods
{
    public class GangNeighbourhood : INeighbourhood
    {
        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {            

            foreach (var gun in mainPlayer.GunRepository.Models)
            {
                while (gun.CanFire)
                {
                    if (civilPlayers.Count == 0)
                    {                        
                        return;//?!?!?!?
                    }

                    var civilPlayer = civilPlayers.First();
                                        
                    civilPlayer.TakeLifePoints(gun.Fire());

                    if (civilPlayer.IsAlive==false)
                    {
                        civilPlayers.Remove(civilPlayer);
                    }
                }

                
            }


            foreach (var civilPlayer in civilPlayers)
            {
                foreach (var gun in civilPlayer.GunRepository.Models)
                {
                    while (gun.CanFire)
                    {
                        if (mainPlayer.IsAlive == false)
                        {
                            return;//?!?!?!?
                        }                                               

                        mainPlayer.TakeLifePoints(gun.Fire());
                                                
                    }


                }
            }
        }
    }
}
