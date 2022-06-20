using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Practick
{
    /// <summary>
    /// Description of the hero, his class, name, cost,role
    /// </summary>
    class DescriptionOfTheHero
    {
      
        private string Clases;
        private string Line;

        private string Name;
        private int Cost;
        public void HeroClass()
        {
            //Description of the class and role
            Clases = "The Demolition Magician: Mage-Gunner";
            Line = "Average: Support";

            Console.WriteLine("HeroClass: ");
            Console.WriteLine($"Class: {Clases}");
            Console.WriteLine($"Line: {Line}");
        }
        public void Champions()
        {
            //Name and cost
            Name = "Lux";
            Cost = 3150;

            Console.WriteLine("Champions: ");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Cost: {Cost}");
            Console.WriteLine();
        }
    }
    internal class Hero
    {
    }
}
