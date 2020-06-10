using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items.Weapons
{
    public sealed class WoodenSword : Weapon
    {
        

        private WoodenSword(string aName, int aDamage, int aRange, int aValue, int aWeight) 
            : base(aName, aDamage, aRange, aValue, aWeight)
        {

        }

        private WoodenSword() : base()
        {

        }
    }
}
