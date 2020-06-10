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

        private WoodenSword(string aName, int aDamage, int aRange, int aValue, int aWeight) 
            : base(aName, aDamage, aRange, aValue, aWeight)
        {
            Name = aName;
            Damage = aDamage;
            Range = aRange;
            Value = aValue;
            Weight = aWeight;
        }

        public WoodenSword() : base()
        {
            Name = _Name;
            Damage = _Damage;
            Range = _Range;
            Value = _Value;
            Weight = _Weight;
        }
    }
}
