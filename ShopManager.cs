using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class ShopManager
    {
        public User user = new User();
        WeaponFactory wf = WeaponFactory.Instance;

        public ShopManager() { }
        /// <summary>
        /// Makes the factory create a new instance of the chosen weapon, which then is the weapon bought by the user
        /// </summary>
        /// <param name="w"></param>
        public void BuyWeapon(Weapon w)
        {
            Weapon weapon = wf.Create(w.Id, w.Onehand, w.Name, w.MinDamage, w.MaxDamage, w.Rarity, w.APS, w.NumberOfProperties);
            user.weapons.Add(weapon);
        }
    }
}
