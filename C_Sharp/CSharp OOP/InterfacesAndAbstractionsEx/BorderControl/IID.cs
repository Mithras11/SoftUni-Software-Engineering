using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IID
    {
        string ID { get; }

        bool findLastDigits(string id);
    }
}
