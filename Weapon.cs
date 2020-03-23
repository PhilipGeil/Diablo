using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    abstract class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public double APS { get; set; }
        public double DPS { get; set; }
        public string Type { get; set; }
        public int NumberOfProperties { get; set; }
        public List<MagicProperties> Primary { get; set; }
        public List<MagicProperties> Secondary { get; set; }

        public Weapon(string name, int damage, string type, double aps, int props)
        {
            Name = name;
            Damage = damage;
            Type = type;
            APS = aps;
            DPS = damage * aps;
            NumberOfProperties = props;
        }


    }
}
