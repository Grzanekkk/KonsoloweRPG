using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items.Weapons
{
    public sealed class WoodenSword : Weapon
    {
        string _Name = "Patyk";
        int _Damage = 2;
        int _Range = 1;
        int _Value = 1;
        int _Weight = 3;

        public WoodenSword(string aName, int aDamage, int aRange, int aValue, int aWeight) 
            : base(aName, aDamage, aRange, aValue, aWeight)
        {
            aName = _Name;
            aDamage = _Damage;
            aRange = _Range;
            aValue = _Value;
            aWeight = _Weight;
        }

        public WoodenSword() : base()
        {

        }
    }
}
