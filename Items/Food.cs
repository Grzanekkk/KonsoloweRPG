using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items.Food
{
    class Food : ItemBase
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
        }
        public override int Weight
        {
            get
            {
                return _Weight;
            }
        }
    }
}
