using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpnDmgclass
{
    class Weapon
    {
        private string name;
        private string type;
        private int weapondamage;
        private int price;
        private int strenghtcost;
        private int dexteritycost;

        public Weapon()
        {
            weapondamage = 0;
            price = 0;
            strenghtcost = 0;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public int Weapondamage
        {
            get { return weapondamage; }
            set { weapondamage = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Strengthcost
        {
            get { return strenghtcost; }
            set { strenghtcost = value; }
        }
        public int Dexteritycost
        {
            get { return dexteritycost; }
            set { dexteritycost = value; }
        }
    }
}
