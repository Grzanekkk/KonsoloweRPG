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

            WoodenSword newWeapon = new WoodenSword("Patyk", 2, 1, 1, 3);

            Console.WriteLine(newWeapon.Name);


            Console.ReadKey();
        }
    }
}
