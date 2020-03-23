using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Program
    {
        static void Main(string[] args)
        {
            WeaponFactory wf = new WeaponFactory();
            Weapon w1 = wf.Create(0);
            Weapon w2 = wf.Create(1);
            PrintWeapon(w1);
            Console.WriteLine();
            Console.WriteLine();
            PrintWeapon(w2);

            Console.ReadKey();
        }

        static void PrintWeapon(Weapon w)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(w.Name);
            Console.WriteLine(w.Type);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(w.Damage);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Damage");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(w.APS);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Attacks per Second");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(w.DPS);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Damage per Second");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Primary ");
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (MagicProperties item in w.Primary)
            {
                Console.WriteLine(item.Prop);
            }
        }
    }
}
