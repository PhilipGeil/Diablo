using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Catalogue
    {

        public Catalogue() { }


        WeaponFactory wf = WeaponFactory.Instance;

        public List<Weapon> GetOneHandedAxes()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                wf.Create(0, true, "Ono", 25, 46, "Rare", 1.30, 4),
                wf.Create(0, true, "Hatchet", 20, 36, "Rare", 1.30, 4),
                wf.Create(0, true, "Marauder Axe", 15, 26, "Axe", 1.30, 0),
                wf.Create(0, true, "Double Axe", 6, 10, "Magic", 1.30, 2),
            };

            return weapons;
        }

        public List<Weapon> GetTwoHandedAxes()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                wf.Create(0, false, "War Axe", 14, 16, "Magic", 1, 3),
                wf.Create(0, false, "Tabarzin", 45, 54, "Rare", 1, 4),
                wf.Create(0, false, "Military Axe", 60, 72, "Rare", 1, 4),
                wf.Create(0, false, "King Maker", 9, 11, "Two-Handed Axe", 1, 0),
            };

            return weapons;
        }
        public List<Weapon> GetOneHandedSwords()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                wf.Create(1, true, "King's Sword of Haste", 2, 4, "Magic", 1.4, 3),
                wf.Create(1, true, "Griswold's Edge", 2, 4, "Magic", 1.4, 3),
                wf.Create(1, true, "Scimitar", 11, 24, "Rare", 1.4, 4),
                wf.Create(1, true, "War Sword", 12, 28, "Rare", 1.4, 4),
            };

            return weapons;
        }

        public List<Weapon> GetTwoHandedSwords()
        {
            List<Weapon> weapons = new List<Weapon>
            {
                wf.Create(1, false, "Two-Handed Sword", 8, 12, "Two-Handed Sword", 1.1, 0),
                wf.Create(1, false, "Dervish", 36, 53, "Rare", 1.1, 4),
                wf.Create(1, false, "Reaver", 96, 142, "Two-Handed Sword", 1.1, 0),
                wf.Create(1, false, "Kilij", 114, 169, "Rare", 1.1, 4),
            };

            return weapons;
        }

        public List<Weapon> GetOneHandedSpears()
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                wf.Create(2, true, "Javelin", 5, 7, "Spear", 1.2, 0),
                wf.Create(2, true, "Disemboweler", 353, 526, "Rare", 1.2, 6),
                wf.Create(2, true, "Hasta", 17, 24, "Spear", 1.2, 0),
                wf.Create(2, true, "Pilum", 22, 32, "Spear", 1.2, 0),
            };

            return weapons;
        }

        public List<Weapon> GetOneHandedDaggers()
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                wf.Create(3, true, "Short Dagger", 5, 15, "Magic", 1.5, 2),
                wf.Create(3, true, "Poignard", 7, 21, "Rare", 1.5, 4),
                wf.Create(3, true, "Pugio", 17, 50, "Rare", 1.5, 4),
                wf.Create(3, true, "Rondel", 19, 57, "Dagger", 1.5, 0),
            };

            return weapons;
        }

        public List<Weapon> GetOneHandedCeremonialKnifes()
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                wf.Create(4, true, "Kris Blade", 4, 17, "Ceremonial Knife", 1.4, 0),
                wf.Create(4, true, "Flint Knife", 9, 35, "Rare", 1.4, 4),
                wf.Create(4, true, "Ox Bone Blade", 10, 41, "Rare", 1.4, 4),
                wf.Create(4, true, "Sacrifice Blade", 11, 45, "Ceremonial Knife", 1.4, 0),
            };

            return weapons;
        }

        public List<Weapon> GetOneHandedScythes()
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                wf.Create(5, true, "Falx", 6, 10, "Rare", 1.3, 4),
                wf.Create(5, true, "Harpe", 8, 14, "Scythe", 1.3, 0),
                wf.Create(5, true, "Artisan Scythe", 16, 28, "Rare", 1.3, 4),
                wf.Create(5, true, "Khopesh", 20, 35, "Scythe", 1.3, 0),
            };

            return weapons;
        }

        public List<Weapon> GetTwoHandedScythes()
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                wf.Create(5, false, "Kusa Scythe", 10, 10, "Rare", 1.1, 4),
                wf.Create(5, false, "Sharp Scythe", 1098, 1209, "Two-Handed Scythe", 1.1, 0),
                wf.Create(5, false, "Sawtooth Scythe", 1461, 1607, "Rare", 1.1, 6),
                wf.Create(5, false, "Kontos", 587, 644, "Rare", 1.1, 5),
            };

            return weapons;
        }

        public List<Weapon> GetOneHandedFistWeapons()
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                wf.Create(6, true, "Worn Knuckles", 2, 3, "Fist Weapon", 1.2, 0),
                wf.Create(6, true, "Shuko", 13, 29, "Rare", 1.4, 4),
                wf.Create(6, true, "Piercer", 16, 36, "Rare", 1.4, 4),
                wf.Create(6, true, "Breaker", 17, 38, "Fist Weapon", 1.4, 0),
            };

            return weapons;
        }

        public List<Weapon> GetOneHandedFlails()
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                wf.Create(7, true, "Spiked Flail", 4, 7, "Flail", 1.4, 0),
                wf.Create(7, true, "Thresher", 13, 23, "Rare", 1.4, 4),
                wf.Create(7, true, "Flail", 15, 27, "Rare", 1.4, 4),
                wf.Create(7, true, "Ball and Chain", 18, 32, "Rare", 1.4, 4),
            };

            return weapons;
        }

        public List<Weapon> GetTwoHandedFlails()
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                wf.Create(7, false, "Battle Flail", 13, 13, "Two-Handed Flail", 1.15, 0),
                wf.Create(7, false, "Grand Thresher", 39, 42, "Two-Handed Flail", 1.15, 0),
                wf.Create(7, false, "Angelic Grand Flail", 1351, 1486, "Rare", 1.15, 6),
                wf.Create(7, false, "Baroque Grand Flail", 986, 1082, "Two-Handed Flail", 1.15, 0),
            };

            return weapons;
        }

        public List<Weapon> GetOneHandedMightyWeapons()
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                wf.Create(8, true, "Maw Axe", 12, 21, "Rare", 1.3, 4),
                wf.Create(8, true, "War Blade", 17, 31, "Rare", 1.3, 4),
                wf.Create(8, true, "Slayer", 150, 277, "Mighty Weapon", 1.3, 0),
                wf.Create(8, true, "Limb Cleaver", 249, 461, "Rare", 1.3, 6),
            };

            return weapons;
        }

        public List<Weapon> GetTwoHandedMightyWeapons()
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                wf.Create(8, false, "Battersmash", 467, 510, "Two-Handed Mighty Weapon", 1, 0),
                wf.Create(8, false, "Titan Axe", 982, 1078, "Rare", 1, 0),
                wf.Create(8, false, "Hassan Chopper", 1096, 1205, "Two-Handed Mighty Weapon", 1.1, 0),
                wf.Create(8, false, "Steppes Smasher", 1462, 1609, "Rare", 1.1, 6),
            };

            return weapons;
        }

        public List<Weapon> GetOneHandedMaces()
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                wf.Create(9, true, "Cudgel", 6, 10, "Mace", 1.2, 0),
                wf.Create(9, true, "Flanged Mace", 14, 25, "Rare", 1.2, 4),
                wf.Create(9, true, "Bludgeon", 28, 51, "Rare", 1.2, 4),
                wf.Create(9, true, "Gada", 43, 79, "Rare", 1.2, 5),
            };

            return weapons;
        }

        public List<Weapon> GetTwoHandedMaces()
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                wf.Create(9, false, "War Maul", 875, 959, "Two-Handed Mace", 0.9, 0),
                wf.Create(9, false, "Slag Hammer", 1027, 1127, "Two-Handed Mace", 0.9, 0),
                wf.Create(9, false, "Doom Hammer", 1204, 1323, "Two-Handed Mace", 0.9, 0),
                wf.Create(9, false, "Persuader", 1737, 1912, "Rare", 1, 6),
            };

            return weapons;
        }

    }
}
