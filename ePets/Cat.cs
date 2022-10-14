using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ePets
{
    class Cat : Pet
    {
        private string Img;
        private string Name;
        private int Hunger;
        private int Happiness;

        public Cat()
        {
            Img = @"

       |\     _,,,---,,_
ZZZzz /,`.-'`'    -.  ;-;;,_
     |,4-  ) )-,_. ,\ (  `'-'
    '---''(_/--'  `-'\_);";

            Name = ReadLine();
            Hunger = 2;
            Happiness = 4;
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

            do
            {
                var startTimeSpan = TimeSpan.Zero;
                var endTimeSpan = TimeSpan.FromMinutes(2);
                var timer = new System.Threading.Timer((e) =>
                {
                    fatigue();
                });
            } while (tf == true);



        }

        public override void pet()
        {
            Happiness -= 2;
            Hunger -= 2;
        }

        public override void feed()
        {
            WriteLine($"what food would you like to try and feed {Name}?\n" +
                "Bacon Snack\nDog Food\nTuna\nCat Food");
            string food = ReadLine();
            if (food.ToLower() == "cat food")
            {
                Hunger %= 2;
                Happiness++;
            }
            else if (food.ToLower() == "tuna")
            {
                Hunger = 0;
                Happiness += 3;
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
            Hunger ++;
            Happiness += 2;
        }

        public override void scold()
        {
            Hunger += 2;
            Happiness -= 2;
        }

        public override void tapGlass()
        {
            Hunger += 2;
            Happiness -= 2;
        }

        public override void talk()
        {
            Hunger += 2;
            Happiness -= 2; 
        }

        public override void playMusic()
        {
            Hunger += 2;
            Happiness -= 2;
        }
    }
}
