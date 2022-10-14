using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



namespace ePets
{
    public class Dog : Pet
    {
        

        public Dog()
        {
            Img = @"
     |\_/|                  
     | @ @   Woof! 
     |   <>              _  
     |  _/\------____ ((| |))
     |               `--' |   
 ____|_       ___|   |___.' 
/_/_____/____/_______|";
            
            Name = ReadLine();
            Hunger = 2;
            Happiness = 2;
            MaxHunger = 10;
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
                var endTimeSpan = TimeSpan.FromMinutes(2);
                var timer = new System.Threading.Timer((e) =>{fatigue();});
        }

        public override void pet()
        {
            Hunger += 2;
            Happiness -= 2;
        }

        public override void feed()
        {
            WriteLine($"what food would you like to try and feed {Name}?\n" +
                "Bacon Snack\nDog Food\nTuna\nCat Food");
            string food = ReadLine();
            if ( food.ToLower() == "bacon" )
            {
                Hunger %= 2;
                Happiness ++;
            }
            else if (food.ToLower() == "dog food")
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
            Hunger++;
            Happiness++;
            
        }
        
        public override void play()
        {
            Hunger += 3;
            Happiness += 2;
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
            Happiness -= 2;
            Hunger -= 2;
        }









    }
 }
