using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Practick
{
    /// <summary>
    /// Description of hero statistics and level increment
    /// </summary>
    class Stata 
    {       
        private int Hp;
        private int Mana;
        private int Level;
        private float Armor;
        private float PowerAtack;
        private float MagicResistance;
        private float RestoringHealth;
        private int SpeedShift;
        private int Range;
        private float ManaRec;


        private float HpLevel = 99f;
        private float ManaLevel = 23.5f;
        private float ArmorLevel=5.2f;
        private float PowerAtackLevel = 3.3f;
        private float MagicLevel = 1.3f;
        private float HealLevel = 0.55f;
        private float ManaRecoveryLevel = 0.8f;

        public void BasicCharacteristics()
        {
            //Output of indicators to the console
            Hp = 560;
            Mana = 480;
            Level = 1;

            Armor = 19f;
            PowerAtack = 54f;
            MagicResistance = 30f;

            RestoringHealth = 14.85f;
            SpeedShift = 330;
            Range = 550;
            ManaRec = 21.6f;

            Console.WriteLine();
            Console.WriteLine("BasicCharacteristics: ");
            Console.WriteLine($"Hp: {Hp}");
            Console.WriteLine($"Mana: {Mana}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Armor: {Armor}");
            Console.WriteLine($"SpeedAtack: {PowerAtack}");
            Console.WriteLine($"MagicResistance: {MagicResistance}");          
            Console.WriteLine($"SpeedShift: {SpeedShift}");
            Console.WriteLine($"Range: {Range}");
            Console.WriteLine();
        }    
        public void Levels()
        {
           
            LevelIndicators();
        }
        private void  LevelIndicators(params float[] LevelIndicators)
        {
            //Array of levels and calculation of HP and mana gains per level
            
            int level;         
            do
            {            
                Console.WriteLine("Choose from levels 1 to 18!");
                Int32.TryParse(Console.ReadLine(), out level);
                
            } while (level < 1 || level > 18);
           
            float[] LevelInd = new float[level];        
            LevelIndicators = LevelInd;

            float Hps = 560f;
            float Man = 480f;
            float Arm = 19f;
            float Atc = 54f;
            float Mag = 22.1f;
            float Heal = 5.5f;
            float ManR = 21.6f;

            float h = 0f;
            float m = 0f;
            float a = 0f;
            float at = 0;
            float mg = 0;
            float he = 0;
            float mn = 0;
                                   
            for (float i = 0; i <= LevelIndicators.Length; i++)
            {                       
                h =Hps + (HpLevel * (level -1));

                for (int J = 0; J <= LevelIndicators.Length; J++)
                {
                    m=Man +(ManaLevel * (level -1));
                }
                for (int k = 0; k < LevelIndicators.Length; k++)
                {
                    a = Arm + (ArmorLevel * (level - 1));
                }
                for (int t = 0; t < LevelIndicators.Length; t++)
                {
                    at = Atc + (PowerAtackLevel * (level - 1));
                }
                for (int g = 0; g < LevelIndicators.Length; g++)
                {
                    mg = Mag + (MagicLevel * (level - 1));
                }
                for (int o = 0; o < LevelIndicators.Length; o++)
                {
                    he = Heal + (HealLevel * (level - 1));
                }
                for (int s = 0; s < LevelIndicators.Length; s++)
                {
                    mn = ManR + (ManaRecoveryLevel * (level - 1));
                }
            }
            Console.WriteLine($"Health boost per level:{level}  = {h}");
            Console.WriteLine($"Mana boost with level:{level} = {m}");
            Console.WriteLine($"Armor gain per level:{level} = {a}");
            Console.WriteLine($"Attack power at the level:{level} = {at}");
            Console.WriteLine($"Magic Resistance per level:{level} = {mg}");
            Console.WriteLine($"Restoring health:{level} = {he}");
            Console.WriteLine($"Mana Recovery:{level} = {mn}");
        }     
    }
    class StataClass
    {       
    }
}
