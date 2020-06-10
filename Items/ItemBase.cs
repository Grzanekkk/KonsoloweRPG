using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public abstract class ItemBase               // Basic props for every item in the game
    {
        public abstract string Name { get; set; }
        public abstract int Value { get; set; }
        public abstract int Weight { get; set; }
    }
}
