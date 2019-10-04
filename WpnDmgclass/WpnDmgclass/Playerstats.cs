using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpnDmgclass
{
    class Playerstats
    {
        private string name;
        private int hp;
        private int strength;
        private int agility;
        private int onehskill;
        private int twohskill;
        private int bowskill;

        public Playerstats()
        {
            hp = 0;
            strength = 0;
            agility = 0;
            onehskill = 0;
            twohskill = 0;
            bowskill = 0;
        }

        public string Name { get; set; }
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public int Agility
        {
            get { return agility; }
            set { agility = value; }
        }
        public int Onehskill
        {
            get { return onehskill; }
            set { onehskill = value; }
        }
        public int Twohskill
        {
            get { return twohskill; }
            set { twohskill = value; }
        }
        public int Bowskill
        {
            get { return bowskill; }
            set { bowskill = value; }
        }
    }
}
