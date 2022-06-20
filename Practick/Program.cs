using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


namespace Practick
{      
     class Program
    {        
        public static void Menu()
        {           
            Stata stata = new Stata();   
            DescriptionOfTheHero descriptionOfTheHero = new DescriptionOfTheHero();
            Console.WriteLine("Choose a hero. Lux or Jeanne!!!");
            bool isFlag = true;
           
            do
            {
                string str = Console.ReadLine();                          
                switch (str)
                    {
                        case "Lux":
                    case "lux":
                            descriptionOfTheHero.Champions();
                            descriptionOfTheHero.HeroClass();
                            stata.BasicCharacteristics();
                            string text = File.ReadAllText(@"C:Lux.txt");
                            Console.WriteLine(text);
                            Console.WriteLine();
                            stata.Levels();                      
                        Menu();
                 
                            break;
                        case "Jeanne":
                    case "jeanne":
                            descriptionOfTheHero.Champions();
                            descriptionOfTheHero.HeroClass();
                            stata.BasicCharacteristics();
                            string text1 = File.ReadAllText(@"C:Jeanne.txt");
                            Console.WriteLine(text1);
                            Console.WriteLine();
                            stata.Levels();
                        Menu();
                            break;
                        default:
                        Console.Clear();                      
                            Console.WriteLine("Choose a hero. Lux or Jeanne!!!");
                            continue;
                       
                }
               
                break;
              
            } while (isFlag);          
        }

       
        static void Main(string[] args)
        {       
            Menu();
            
            Console.ReadLine();
        }
    }
}
