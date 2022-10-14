using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using static System.Console;

namespace ePets
{
    class Fish : Pet
    {
        private string Img;
        private string Name;
        private int Hunger;
        private int Happiness;
        
        public Fish()
        {
            Img = @"

      /`·.¸
     /¸...¸`:·
 ¸.·´  ¸   `·.¸.·´)
: © ):´;      ¸  {
 `·.¸ `·  ¸.·´\`·¸)
     `\\´´\¸.·´ ";

            Name = ReadLine();
            Hunger = 2;
            Happiness = 2;
            MaxHunger = 5;
        }

        public override void display()
        {
            WriteLine($"{Img}\n{Name},\nHunger: {Hunger},\nHappiness: {Happiness}");
        }

        public override void fatigue()
        {
            Hunger++;
            Happiness--;
        }

        public override void timedFatigue()
        {

          
                var startTimeSpan = TimeSpan.Zero;
                var endTimeSpan = TimeSpan.FromMinutes(3);
                var timer = new System.Threading.Timer((e) =>
                {
                    fatigue();
                });



        }

        public override void pet()
        {
            Happiness -= 2;
            Hunger -= 2;
        }

        public override void feed()
        {
            WriteLine($"what food would you like to try and feed {Name}?\n" +
                "Bacon Snack\nDog Food\nTuna\nCat Food\nFish Food");
            string food = ReadLine();
            if (food.ToLower() == "fish food")
            {
                Hunger = 0;
                Happiness ++;
            }
            else
            {
                Hunger += 2;
                Happiness -= 2;
            }
        }


        public override void rubBelly()
        {
            Hunger += 2;
            Happiness -= 2;

        }

        public override void play()
        {
            Hunger += 2;
            Happiness -= 2;
        }

        public override void ignore()
        {
            Hunger += 2;
            Happiness -= 2;
        }

        public override void scold()
        {
            Hunger += 2;
            Happiness -= 2;
        }

        public override void tapGlass()
        {
            Hunger += 3;
            Happiness -= 2;
        }

        public override void talk()
        {
            Hunger ++;
            Happiness ++;
        }

        public override void playMusic()
        {
            Hunger += 3;
            Happiness -= 2;
        }
    }
}
