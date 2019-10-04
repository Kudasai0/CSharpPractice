using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpnDmgclass
{
    class Program
    {
        static void Main(string[] args)
        {
            //WEAPONS
            Weapon oreds = new Weapon();
            oreds.Name = "Ore Dragon Slayer";
            oreds.Type = "One-handed";
            oreds.Weapondamage = 90;
            oreds.Price = 2200;
            oreds.Strengthcost = 80;

            Weapon drgnslicer = new Weapon();
            drgnslicer.Name = "Dragon Slicer";
            drgnslicer.Type = "Two-handed";
            drgnslicer.Weapondamage = 190;
            drgnslicer.Strengthcost = 160;

            Weapon dbow = new Weapon();
            dbow.Name = "Dragon Bow";
            dbow.Type = "Bow";
            dbow.Weapondamage = 75;
            dbow.Price = 2500;
            dbow.Dexteritycost = 95;

            //STATS
            Playerstats hero = new Playerstats();
            hero.Name = "Nameless";
            hero.HP = 520;
            hero.Strength = 150;
            hero.Agility = 90;
            hero.Onehskill = 50;
            hero.Twohskill = 90;
            hero.Bowskill = 30;

            //DAMAGE
            int OredsDMG = (oreds.Weapondamage + hero.Strength) / 10;
            int DrgnslicerDMG = (drgnslicer.Weapondamage + hero.Strength) / 10;

            //CRITDAMAGE
            //Random rnd = new Random();
            //int Weponskillroll = rnd.Next(10);
            //int Oredscritdamage = oreds.Weapondamage + hero.Strength;
            //int Drgnslicercritdamage = drgnslicer.Weapondamage + hero.Strength;



            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
