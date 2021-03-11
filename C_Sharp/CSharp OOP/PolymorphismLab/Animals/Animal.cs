<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; protected set; }
        public string FavouriteFood { get; protected set; }

        protected Animal(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favoriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
        }


    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; protected set; }
        public string FavouriteFood { get; protected set; }

        protected Animal(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favoriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
        }


    }
}
>>>>>>> c25693585f09720b9c59fe3f2bd3001f3feeec59
