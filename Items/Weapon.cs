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
            set
            {
                _Value = value;
            }
        }
        public override int Weight 
        { 
            get
            {
                return _Weight;
            }
            set
            {
                _Weight = value;
            }
        }
        public int Damage
        {
            get
            {
                return _Damage;
            }
            set
            {
                _Damage = value;
            }
        }
        public int Range
        {
            get
            {
                return _Range;
            }
            set
            {
                _Range = value;
            }
        }


        #endregion Fields and Properties

        #region Constructors


        protected Weapon(string aName, int aDamage, int aRange, int aValue, int aWeight)
        {
            _Name = aName;
            _Value = aValue;
            _Weight = aWeight;
            _Damage = aDamage;
            _Range = aRange;
        }

        public Weapon() 
        {
            _Name = "Karolina";
        }



        #endregion Constructors
    }
}
