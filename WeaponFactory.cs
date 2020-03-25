using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class WeaponFactory
    {
        private WeaponFactory() { }

        private static WeaponFactory instance;
        public static WeaponFactory Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new WeaponFactory();
                }
                return instance;
            }
        }

        readonly Random r = new Random();
        /// <summary>
        /// Create's a new weapon
        /// </summary>
        /// <param name="weaponID">0 = Axes 1 = Swords 2 = Spear 3 = Dagger 4 = Ceremonial Knife 5 = Scythe 6 = Fist Weapon 7 = Flail 8 = Mighty Weapon 9 = Mace</param> 
        /// <param name="oneHand">True if One-handed False if Two-handed</param>
        /// <param name="name">Name of the weapon</param>
        /// <param name="minDmg">Minimum damage of the weapon</param>
        /// <param name="maxDmg">Maximum damage of the weapon</param>
        /// <param name="rarity">The rarity of the weapon</param>
        /// <param name="aps">The Attacks per Second</param>
        /// <param name="nop">The Number of properties</param>
        /// <returns></returns>
        public Weapon Create(int weaponID, bool oneHand, string name, int minDmg, int maxDmg, string rarity, double aps, int nop)
        {
            switch (weaponID)
            {
                case 0:
                    return CreateAxe(oneHand, name, minDmg, maxDmg, rarity, aps, nop, weaponID);
                case 1:
                    return CreateSword(oneHand, name, minDmg, maxDmg, rarity, aps, nop, weaponID);
                case 2:
                    return CreateSpear(oneHand, name, minDmg, maxDmg, rarity, aps, nop, weaponID);
                case 3:
                    return CreateDagger(oneHand, name, minDmg, maxDmg, rarity, aps, nop, weaponID);
                case 4:
                    return CreateCeremonialKnife(oneHand, name, minDmg, maxDmg, rarity, aps, nop, weaponID);
                case 5:
                    return CreateScythe(oneHand, name, minDmg, maxDmg, rarity, aps, nop, weaponID);
                case 6:
                    return CreateFistWeapon(oneHand, name, minDmg, maxDmg, rarity, aps, nop, weaponID);
                case 7:
                    return CreateFlail(oneHand, name, minDmg, maxDmg, rarity, aps, nop, weaponID);
                case 8:
                    return CreateMightyWeapon(oneHand, name, minDmg, maxDmg, rarity, aps, nop, weaponID);
                case 9:
                    return CreateMace(oneHand, name, minDmg, maxDmg, rarity, aps, nop, weaponID);
                default:
                    break;
            }
            return null;
        }
        /// <summary>
        /// Creates an axe
        /// </summary>
        /// <param name="oneHand"></param>
        /// <param name="name"></param>
        /// <param name="minDmg"></param>
        /// <param name="maxDmg"></param>
        /// <param name="rarity"></param>
        /// <param name="aps"></param>
        /// <param name="nop"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private Weapon CreateAxe(bool oneHand, string name, int minDmg, int maxDmg, string rarity, double aps, int nop, int id)
        {
            Weapon axe = new Axe(name, minDmg, maxDmg, rarity, aps, oneHand, nop, id);
            GetDamage(axe);
            GetProperties(axe, oneHand);
            return axe;
        }
        /// <summary>
        /// Creates a sword
        /// </summary>
        /// <param name="oneHand"></param>
        /// <param name="name"></param>
        /// <param name="minDmg"></param>
        /// <param name="maxDmg"></param>
        /// <param name="rarity"></param>
        /// <param name="aps"></param>
        /// <param name="nop"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private Weapon CreateSword(bool oneHand, string name, int minDmg, int maxDmg, string rarity, double aps, int nop, int id)
        {
            Weapon sword = new Sword(name, minDmg, maxDmg, rarity, aps, oneHand, nop, id);
            GetDamage(sword);
            GetProperties(sword, oneHand);
            return sword;
        }
        /// <summary>
        /// Creates a spear
        /// </summary>
        /// <param name="oneHand"></param>
        /// <param name="name"></param>
        /// <param name="minDmg"></param>
        /// <param name="maxDmg"></param>
        /// <param name="rarity"></param>
        /// <param name="aps"></param>
        /// <param name="nop"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private Weapon CreateSpear(bool oneHand, string name, int minDmg, int maxDmg, string rarity, double aps, int nop, int id)
        {
            Weapon spear = new Spear(name, minDmg, maxDmg, rarity, aps, oneHand, nop, id);
            GetDamage(spear);
            GetProperties(spear, oneHand);
            return spear;
        }
        /// <summary>
        /// Creates a dagger
        /// </summary>
        /// <param name="oneHand"></param>
        /// <param name="name"></param>
        /// <param name="minDmg"></param>
        /// <param name="maxDmg"></param>
        /// <param name="rarity"></param>
        /// <param name="aps"></param>
        /// <param name="nop"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private Weapon CreateDagger(bool oneHand, string name, int minDmg, int maxDmg, string rarity, double aps, int nop, int id)
        {
            Weapon dagger = new Dagger(name, minDmg, maxDmg, rarity, aps, oneHand, nop, id);
            GetDamage(dagger);
            GetProperties(dagger, oneHand);
            return dagger;
        }
        /// <summary>
        /// Creates a ceremonial knife
        /// </summary>
        /// <param name="oneHand"></param>
        /// <param name="name"></param>
        /// <param name="minDmg"></param>
        /// <param name="maxDmg"></param>
        /// <param name="rarity"></param>
        /// <param name="aps"></param>
        /// <param name="nop"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private Weapon CreateCeremonialKnife(bool oneHand, string name, int minDmg, int maxDmg, string rarity, double aps, int nop, int id)
        {
            Weapon knife = new CeremonialKnife(name, minDmg, maxDmg, rarity, aps, oneHand, nop, id);
            GetDamage(knife);
            GetProperties(knife, oneHand);
            return knife;
        }
        /// <summary>
        /// Creates a scythe
        /// </summary>
        /// <param name="oneHand"></param>
        /// <param name="name"></param>
        /// <param name="minDmg"></param>
        /// <param name="maxDmg"></param>
        /// <param name="rarity"></param>
        /// <param name="aps"></param>
        /// <param name="nop"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private Weapon CreateScythe(bool oneHand, string name, int minDmg, int maxDmg, string rarity, double aps, int nop, int id)
        {
            Weapon scythe = new Scythe(name, minDmg, maxDmg, rarity, aps, oneHand, nop, id);
            GetDamage(scythe);
            GetProperties(scythe, oneHand);
            return scythe;
        }
        /// <summary>
        /// Creates a fist weapon
        /// </summary>
        /// <param name="oneHand"></param>
        /// <param name="name"></param>
        /// <param name="minDmg"></param>
        /// <param name="maxDmg"></param>
        /// <param name="rarity"></param>
        /// <param name="aps"></param>
        /// <param name="nop"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private Weapon CreateFistWeapon(bool oneHand, string name, int minDmg, int maxDmg, string rarity, double aps, int nop, int id)
        {
            Weapon fist = new FistWeapon(name, minDmg, maxDmg, rarity, aps, oneHand, nop, id);
            GetDamage(fist);
            GetProperties(fist, oneHand);
            return fist;
        }
        /// <summary>
        /// Creates a flail
        /// </summary>
        /// <param name="oneHand"></param>
        /// <param name="name"></param>
        /// <param name="minDmg"></param>
        /// <param name="maxDmg"></param>
        /// <param name="rarity"></param>
        /// <param name="aps"></param>
        /// <param name="nop"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private Weapon CreateFlail(bool oneHand, string name, int minDmg, int maxDmg, string rarity, double aps, int nop, int id)
        {
            Weapon flail = new Flail(name, minDmg, maxDmg, rarity, aps, oneHand, nop, id);
            GetDamage(flail);
            GetProperties(flail, oneHand);
            return flail;
        }
        /// <summary>
        /// Creates a mighty weapon
        /// </summary>
        /// <param name="oneHand"></param>
        /// <param name="name"></param>
        /// <param name="minDmg"></param>
        /// <param name="maxDmg"></param>
        /// <param name="rarity"></param>
        /// <param name="aps"></param>
        /// <param name="nop"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private Weapon CreateMightyWeapon(bool oneHand, string name, int minDmg, int maxDmg, string rarity, double aps, int nop, int id)
        {
            Weapon mighty = new MightyWeapon(name, minDmg, maxDmg, rarity, aps, oneHand, nop, id);
            GetDamage(mighty);
            GetProperties(mighty, oneHand);
            return mighty;
        }
        /// <summary>
        /// Creates a mace
        /// </summary>
        /// <param name="oneHand"></param>
        /// <param name="name"></param>
        /// <param name="minDmg"></param>
        /// <param name="maxDmg"></param>
        /// <param name="rarity"></param>
        /// <param name="aps"></param>
        /// <param name="nop"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private Weapon CreateMace(bool oneHand, string name, int minDmg, int maxDmg, string rarity, double aps, int nop, int id)
        {
            Weapon mace = new Mace(name, minDmg, maxDmg, rarity, aps, oneHand, nop, id);
            GetDamage(mace);
            GetProperties(mace, oneHand);
            return mace;
        }
        /// <summary>
        /// Set the damage randomly within the range of the weapon
        /// </summary>
        /// <param name="w"></param>
        private void GetDamage(Weapon w)
        {
            w.Damage = r.Next(w.MinDamage, w.MaxDamage);
        }
        /// <summary>
        /// Gets the properties for the weapon
        /// </summary>
        /// <param name="w"></param>
        /// <param name="oneHand"></param>
        private void GetProperties(Weapon w, bool oneHand)
        {
            List<int> buffer = new List<int>();
            List<MagicProperties> temp = new List<MagicProperties>();
            for (int i = 0; i < w.NumberOfProperties; i++)
            {
                bool check = false;
                while (!check)
                {
                    int index = r.Next(0, 9);
                    if (!buffer.Contains(index))
                    {
                        temp.Add(new MagicProperties(oneHand, index, r));
                        buffer.Add(index);
                        check = true;
                    }
                }
            }
            w.Primary = temp;
        }
    }
}
