using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Wayne Pud
 * Date: July 13, 2017
 * Description: Demo for lesson 9
 * Version: 0.7 - Implemented the supervillain class
 */


namespace COMP123_S2017_Lesson10B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("SuperHero Dude", 20);
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            superHero.AddPower("Webcasting", 40);
            //SuperHero.DisplayPowers();

            Console.WriteLine(superHero.ToString());
            Console.WriteLine("karma: " + superHero.Karma);

            // For Lab 24

            SuperVillian supervillain = new SuperVillian("SuperVillain Tom", 50002321);
            supervillain.AddPower("Giving homework", 9000);
            supervillain.AddPower("Hard marker", 100000);
            supervillain.AddPower("Giving good marks", 0);
            Console.WriteLine(supervillain.ToString());
            Console.WriteLine("Malice: Wayyyy too much --> " + supervillain.Malice);

            if (superHero is SuperHuman)
            {
                Console.WriteLine("Superhero is a superHuman");
            }

            if (superHero is SuperHero)
            {
                Console.WriteLine("Superhero is a superHero");
            }

            if (superHero is Human)
            {
                Console.WriteLine("Superhero is a Human");
            }
            if (superHero is object)
            {
                Console.WriteLine("Superhero is a an object");
            }

            if (superHero is IHasKarma)
            {
                Console.WriteLine("SuperHero has karma");
            }

            Console.WriteLine(supervillain._getPowerIndex("Hard marker")); 
        }
    }
}
