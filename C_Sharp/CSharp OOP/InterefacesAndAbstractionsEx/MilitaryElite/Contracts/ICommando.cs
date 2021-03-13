using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts
{
   public  interface ICommando
    {
        ICollection<IMission> Missions { get; }
    }
}
