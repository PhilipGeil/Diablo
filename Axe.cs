using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Diablo
{
    class Axe : Weapon
    {
        public Axe(string name, int minDamage, int maxDamage, string rarity, double aps, bool oneHand, int props, int id) : base(name, minDamage, maxDamage, rarity, aps, oneHand, props, id) { }
    }
}
