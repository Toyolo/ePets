using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace ePets
{
    public abstract class Pet  // base class (parent) 
    {
        public int MaxHunger { get; set; }
        public int Hunger { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        public int Happiness { get; set; }

        public bool Starved
        {
            get { return Hunger > MaxHunger; }
        }

        public bool Unhappy
        {
            get { return 0 > Happiness; }
        }

        public abstract void display();

        public abstract void fatigue();

        public abstract void pet();


        public abstract void feed();


        public abstract void rubBelly();


        public abstract void play();


        public abstract void ignore();


        public abstract void scold();

        public abstract void tapGlass();

        public abstract void talk();

        public abstract void playMusic();

        public abstract void timedFatigue();
        


    }
}