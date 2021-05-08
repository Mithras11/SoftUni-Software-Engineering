using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts
{
    public interface IEngineer
    {
        ICollection<IRepair> Repairs { get; }
    }

}
