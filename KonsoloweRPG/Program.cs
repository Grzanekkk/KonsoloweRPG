using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Weapons;
using Characters;

namespace KonsoloweRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w nowej grze!");

            WoodenSword newWeapon = new WoodenSword();
            Weapon weapon = new Weapon();

            Console.WriteLine(newWeapon.Name);
            Console.WriteLine(newWeapon.Damage);
            Console.WriteLine(newWeapon.Range);
            Console.WriteLine(newWeapon.Value);
            Console.WriteLine(newWeapon.Weight);
            Console.WriteLine(weapon.Name);


            Console.ReadKey();
        }
    }
}
