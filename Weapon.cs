using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Diablo
{
    public abstract class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public double APS { get; set; }
        public double DPS { get; set; }
        public string Rarity { get; set; }
        public int NumberOfProperties { get; set; }
        public bool Onehand { get; set; }
        public int Id { get; set; }
        public List<MagicProperties> Primary { get; set; }
        public List<MagicProperties> Secondary { get; set; }

        public Weapon(string name, int minDamage, int maxDamage, string rarity, double aps, bool oneHand, int props, int id)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Rarity = rarity;
            APS = aps;
            DPS = ((maxDamage - minDamage) / 2 + minDamage) * aps;
            Onehand = oneHand;
            NumberOfProperties = props;
            Id = id;
        }


    }
}
