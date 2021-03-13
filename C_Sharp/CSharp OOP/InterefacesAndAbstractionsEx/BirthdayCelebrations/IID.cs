using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public interface IID
    {
        string ID { get; }

        bool FindLastDigits(string id);
    }
}
