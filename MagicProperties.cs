using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class MagicProperties
    {
        public string Prop { get; private set; }
        public List<string> TwoHander = new List<string>();

        public MagicProperties(string indicator, int index)
        {
            switch (indicator)
            {
                case "Onehander":
                    InitializeOneHander(index);
                    break;
                case "Twohander":
                    InitializeTwoHander(index);
                    break;
                default:
                    break;
            }
        }

        private void InitializeOneHander(int index)
        {
            Random r = new Random();
            List<string> oneHander = new List<string>();
            oneHander.Add("+ " + r.Next(5, 9) + "-" + r.Next(10, 15) + " Damage");
            oneHander.Add("+ " + r.Next(8, 19) + "%" + " Damage");
            oneHander.Add("Attack Speed Increased by " + r.Next(10, 17) + "%");
            oneHander.Add("Regenerates " + r.Next(5, 9) + " Life per Second");
            oneHander.Add("Chance to Deal " + r.Next(10, 26) + "%" + " area damage on Hit");
            oneHander.Add(r.Next(8, 15) + " Life per Hit");
            oneHander.Add("Reduces Cooldown of all Skills by " + r.Next(8, 15) + "%");
            oneHander.Add("Reduces all Resource Costs by " + r.Next(10, 17) + "%");
            oneHander.Add(r.Next(8, 19) + "%" + " Chance to Inflict Bleed for " + r.Next(10, 26) + "Weapon Damage over " + r.Next(1, 6) + "Seconds");

            Prop = oneHander[index];

        }

        private void InitializeTwoHander(int index)
        {
            Random r = new Random();
            List<string> twoHander = new List<string>();
            twoHander.Add("+ " + r.Next(5, 9) + "-" + r.Next(10, 15) + " Damage");
            twoHander.Add("+ " + r.Next(8, 19) + "%" + " Damage");
            twoHander.Add("Attack Speed Increased by " + r.Next(10, 17) + "%");
            twoHander.Add("Regenerates " + r.Next(5, 9) + " Life per Second");
            twoHander.Add("Chance to Deal " + r.Next(10, 26) + "%" + " area damage on Hit");
            twoHander.Add(r.Next(8, 15) + " Life per Hit");
            twoHander.Add("Reduces Cooldown of all Skills by " + r.Next(8, 15) + "%");
            twoHander.Add("Reduces all Resource Costs by " + r.Next(10, 17) + "%");
            twoHander.Add(r.Next(8, 19) + "%" + " Chance to Inflict Bleed for " + r.Next(10, 26) + "Weapon Damage over " + r.Next(1, 6) + "Seconds");

            Prop = twoHander[index];

        }
    }
}
