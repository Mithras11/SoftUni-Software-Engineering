<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favoriteFood)
            : base(name, favoriteFood)
        {

        }


        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "MEEOW";

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favoriteFood)
            : base(name, favoriteFood)
        {

        }


        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "MEEOW";

        }
    }
}
>>>>>>> c25693585f09720b9c59fe3f2bd3001f3feeec59
