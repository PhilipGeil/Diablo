using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Mace : Weapon
    {
        public Mace(string name, int minDamage, int maxDamage, string rarity, double aps, bool oneHand, int props, int id) : base(name, minDamage, maxDamage, rarity, aps, oneHand, props, id) { }
    }
}
