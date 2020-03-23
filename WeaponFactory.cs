using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class WeaponFactory
    {
        public WeaponFactory() { }

        public Weapon Create(int indicator)
        {
            switch (indicator)
            {
                case 0:
                    return CreateAxe(0);
                case 1:
                    return CreateAxe(1);
                default:
                    break;
            }
            return null;
        }

        private Weapon CreateAxe(int indicator)
        {
            Random r = new Random();
            if (indicator == 0)
            {
                Weapon axe = new OneHandedAxe("Ono", r.Next(25, 46), "Rare Axe", 1.30, 4);
                GetProperties(axe);
                return axe;
            }
            else if (indicator == 1)
            {
                Weapon axe = new TwoHandedAxe("War Axe", r.Next(14, 17), "Magic Two-Handed Axe", 1, 3);
                GetProperties(axe);
                return axe;
            }
            else
            {
                return null;
            }
        }

        private void GetProperties(Weapon w)
        {
            List<int> buffer = new List<int>();
            Random r = new Random();
            List<MagicProperties> temp = new List<MagicProperties>();
            for (int i = 0; i < w.NumberOfProperties; i++)
            {
                bool check = false;
                while (!check)
                {
                    int index = r.Next(0, 9);
                    if (!buffer.Contains(index))
                    {
                        temp.Add(new MagicProperties("Onehander", index));
                        buffer.Add(index);
                        check = true;
                    }
                }
            }
            w.Primary = temp;
        }
    }
}
