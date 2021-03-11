<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog:Animal
    {
        public Dog(string name, string favoriteFood)
           : base(name, favoriteFood)
        {

        }


        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "DJAAF";

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog:Animal
    {
        public Dog(string name, string favoriteFood)
           : base(name, favoriteFood)
        {

        }


        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "DJAAF";

        }
    }
}
>>>>>>> c25693585f09720b9c59fe3f2bd3001f3feeec59
