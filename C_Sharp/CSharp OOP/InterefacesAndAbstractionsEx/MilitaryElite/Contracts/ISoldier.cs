using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts
{
    public interface ISoldier
    {
        string ID { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}
