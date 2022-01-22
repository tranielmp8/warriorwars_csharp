using System;
using WarriorWars.Enum;
using System.Threading;

namespace WarriorWars
{
    internal class Program
    {
        static Random rng = new Random();
        static void Main(string[] args)
        {
            var goodGuy = new Warrior("Batman", Faction.GoodGuy);
            var badGuy = new Warrior("Joker", Faction.BadGuy);  


            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0, 10)< 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
                Thread.Sleep(100);

            }

        }
    }
}
