using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class User
    {
        public string UserName { get; set; }
        public List<Weapon> weapons = new List<Weapon>();

        public User() { }
    }
}
