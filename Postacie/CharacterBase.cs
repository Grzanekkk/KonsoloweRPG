using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public abstract class CharacterBase
    {
        public abstract string Name { get; set; }
        public abstract int Health { get; set; }
        public abstract int Damage { get; set; }
        public abstract int Level { get; set; }
        public abstract int ExpPoints { get; set; }
        public abstract int Dexterity { get; set; }

        // public abstract List<Skill> SkillList { get; set; }
        // public abstract List<Item> Inventory {get; set;}
        // public abstract List<Item> Equipment {get; set;} ???

    }
}
