using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public interface IBuyer
    {
        string Name { get; }
        int Food { get; }
        void BuyGood();
    }
}
