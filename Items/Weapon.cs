using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items.Weapons
{
    public class Weapon : ItemBase
    {
        #region Fields and Properties

        string _Name;
        int _Value;
        int _Weight;
        int _Damage;
        int _Range;

        public override string Name 
        { 
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public override int Value 
        { 
            get
            {
                return _Value;
            }
        }
        public override int Weight 
        { 
            get
            {
                return _Weight;
            }
        }
        public int Damage
        {
            get
            {
                return _Damage;
            }
        }
        public int Range
        {
            get
            {
                return _Range;
            }
        }


        #endregion Fields and Properties

        #region Constructors


        public Weapon(string aName, int aDamage, int aRange, int aValue, int aWeight)
        {
            _Name = aName;
            _Value = aValue;
            _Weight = aWeight;
            _Damage = aDamage;
            _Range = aRange;
        }

        public Weapon() { }



        #endregion Constructors
    }
}
