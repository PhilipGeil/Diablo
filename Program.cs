using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Program
    {
        static Catalogue catalogue = new Catalogue();
        static ShopManager sm = new ShopManager();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Diablo");
            Console.WriteLine("Enter your username");
            sm.user.UserName = Console.ReadLine();
            while (true)
            {
                Console.Clear();
                Console.WriteLine(sm.user.UserName);
                Console.WriteLine();
                Menu();
            }
        }
        /// <summary>
        /// Show the menu
        /// </summary>
        static void Menu()
        {
            List<string> options = new List<string>()
            {
                 "One-handed Axes",
                 "Two-handed Axes",
                 "One-handed Swords",
                 "Two-handed Swords",
                 "One-Handed Spears",
                 "One-Handed Daggers",
                 "One-handed Ceremonial Knifes",
                 "One-handed Scythes",
                 "Two-handed Scythes",
                 "One-handed Fist Weapons",
                 "One-handed Flails",
                 "Two-handed Flails",
                 "One-handed Mighty Weapons",
                 "Two-handed Mighty Weapons",
                 "One-handed Maces",
                 "Two-handed Maces",
                 "Inventory"
            };
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, options[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Enter your choise: ");
            Selector(int.Parse(Console.ReadLine()));
        }
        /// <summary>
        /// Method used to handle the selection from the menu
        /// </summary>
        /// <param name="choise"></param>
        static void Selector(int choise)
        {
            List<Weapon> weapons = new List<Weapon>();
            switch (choise)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("One-handed Axes");
                    weapons = catalogue.GetOneHandedAxes();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Two-handed Axes");
                    weapons = catalogue.GetTwoHandedAxes();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("One-handed Swords");
                    weapons = catalogue.GetOneHandedSwords();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Two-handed Swords");
                    weapons = catalogue.GetTwoHandedSwords();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("One-handed Spears");
                    weapons = catalogue.GetOneHandedSpears();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("One-handed Daggers");
                    weapons = catalogue.GetOneHandedDaggers();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("One-handed Ceremonial Knifes");
                    weapons = catalogue.GetOneHandedCeremonialKnifes();
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("One-handed Scythes");
                    weapons = catalogue.GetOneHandedScythes();
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("Two-handed Scythes");
                    weapons = catalogue.GetTwoHandedScythes();
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("One-handed Fist Weapons");
                    weapons = catalogue.GetOneHandedFistWeapons();
                    break;
                case 11:
                    Console.Clear();
                    Console.WriteLine("One-handed Flails");
                    weapons = catalogue.GetOneHandedFlails();
                    break;
                case 12:
                    Console.Clear();
                    Console.WriteLine("Two-handed Flails");
                    weapons = catalogue.GetTwoHandedFlails();
                    break;
                case 13:
                    Console.Clear();
                    Console.WriteLine("One-handed Mighty Weapons");
                    weapons = catalogue.GetOneHandedMightyWeapons();
                    break;
                case 14:
                    Console.Clear();
                    Console.WriteLine("Two-handed Mighty Weapons");
                    weapons = catalogue.GetTwoHandedMightyWeapons();
                    break;
                case 15:
                    Console.Clear();
                    Console.WriteLine("One-handed Maces");
                    weapons = catalogue.GetOneHandedMaces();
                    break;
                case 16:
                    Console.Clear();
                    Console.WriteLine("Two-handed Maces");
                    weapons = catalogue.GetTwoHandedMaces();
                    break;
                case 17:
                    Console.Clear();
                    Console.WriteLine("Here is your weapons: ");
                    foreach (Weapon item in sm.user.weapons)
                    {
                        PrintOwnedWeapon(item);
                    }
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
            if (weapons.Count != 0)
            {
                for (int i = 0; i < weapons.Count; i++)
                {
                    Console.WriteLine((i + 1) + ".");
                    PrintCatalogueWeapon(weapons[i]);
                }
                sm.BuyWeapon(weapons[BuyWeapon() - 1]);
            }
        }
        /// <summary>
        /// Prints the weapons, but only showing the number of properties
        /// </summary>
        /// <param name="w"></param>
        static void PrintCatalogueWeapon(Weapon w)
        {
            HandleRarity(w);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(w.MinDamage);
            Console.Write(" - ");
            Console.Write(w.MaxDamage);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Damage");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(w.APS);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Attacks per Second");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(((w.MaxDamage - w.MinDamage) / 2 + w.MinDamage) * w.APS);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Damage per Second");
            Console.ForegroundColor = ConsoleColor.White;
            if (w.NumberOfProperties != 0)
            {
                Console.WriteLine("Primary ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(w.NumberOfProperties + " Random Magic Properties");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();
        }
        /// <summary>
        /// Sets the ForegroundColor accordingly to the rarity of the weapon
        /// </summary>
        /// <param name="w"></param>
        static void HandleRarity(Weapon w)
        {
            if (w.Rarity == "Rare")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(w.Name);
                Console.WriteLine(w.Rarity);
            }
            else if (w.Rarity == "Magic")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(w.Name);
                Console.WriteLine(w.Rarity);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(w.Name);
                Console.WriteLine(w.Rarity);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Initializes the purchase of the chosen weapon
        /// </summary>
        /// <returns></returns>
        static int BuyWeapon()
        {
            Console.WriteLine("Enter the number of the weapon, you wish to purchase");
            return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Prints the owned weapons, where all properties is shown
        /// </summary>
        /// <param name="w"></param>
        static void PrintOwnedWeapon(Weapon w)
        {
            HandleRarity(w);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(w.Damage);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Damage");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(w.APS);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Attacks per Second");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(w.Damage * w.APS);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" Damage per Second");
            Console.ForegroundColor = ConsoleColor.White;
            if (w.NumberOfProperties != 0)
            {
                Console.WriteLine("Primary ");
                Console.ForegroundColor = ConsoleColor.Blue;
                foreach (MagicProperties item in w.Primary)
                {
                    Console.WriteLine(item.Prop);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
