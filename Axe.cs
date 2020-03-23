using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    abstract class Axe : Weapon
    {
        public Axe(string name, int damage, string type, double aps, int props) : base(name, damage, type, aps, props) { }
    }
}
