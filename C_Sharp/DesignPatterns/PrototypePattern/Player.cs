using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    class Player
    {

        public Player(string name)
        {
            this.Name = name;
        }
        public  string Name { get; set; }
    }
}
