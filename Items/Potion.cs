using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Items.Potions
{
    class Potion : ItemBase
    {
        string _Name;
        int _Value;
        int _Weight;

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
    }
}
