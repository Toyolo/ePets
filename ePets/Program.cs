using System;
using static System.Console; //to avoid using tedious typing
using System.Threading.Tasks;

namespace ePets
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Title = "*+++ePets+++*";
            WriteLine(@"
                                                                                                
                                                                                                
                  PPPPPPPPPPPPPPPPP                              tttt                           
                  P::::::::::::::::P                          ttt:::t                           
                  P::::::PPPPPP:::::P                         t:::::t                           
                  PP:::::P     P:::::P                        t:::::t                           
    eeeeeeeeeeee    P::::P     P:::::P  eeeeeeeeeeee    ttttttt:::::ttttttt        ssssssssss   
  ee::::::::::::ee  P::::P     P:::::Pee::::::::::::ee  t:::::::::::::::::t      ss::::::::::s  
 e::::::eeeee:::::eeP::::PPPPPP:::::Pe::::::eeeee:::::eet:::::::::::::::::t    ss:::::::::::::s 
e::::::e     e:::::eP:::::::::::::PPe::::::e     e:::::etttttt:::::::tttttt    s::::::ssss:::::s
e:::::::eeeee::::::eP::::PPPPPPPPP  e:::::::eeeee::::::e      t:::::t           s:::::s  ssssss 
e:::::::::::::::::e P::::P          e:::::::::::::::::e       t:::::t             s::::::s      
e::::::eeeeeeeeeee  P::::P          e::::::eeeeeeeeeee        t:::::t                s::::::s   
e:::::::e           P::::P          e:::::::e                 t:::::t    ttttttssssss   s:::::s 
e::::::::e        PP::::::PP        e::::::::e                t::::::tttt:::::ts:::::ssss::::::s
 e::::::::eeeeeeeeP::::::::P         e::::::::eeeeeeee        tt::::::::::::::ts::::::::::::::s 
  ee:::::::::::::eP::::::::P          ee:::::::::::::e          tt:::::::::::tt s:::::::::::ss  
    eeeeeeeeeeeeeePPPPPPPPPP            eeeeeeeeeeeeee            ttttttttttt    sssssssssss    
                                                                                                
                                                                                                ");
            WriteLine("Welcome to ePets!\nWe are running low on pets right now but we still have a dog, a fish, and a cat.\nWhich one catches your eye?");


            bool active = true;
            do
            {
                WriteLine("1. Buy a pet!");
                WriteLine("Q. Exit");
                string response = ReadLine();

                if (response == "1")
                {
                    WriteLine("Take a look at our available pets!");
                    WriteLine(@"


     |\_/| 
     | @ @   Woof! 
     |   <>              _  
     |  _/\------____ ((| |))
     |               `--' |   
 ____|_       ___|   |___.' 
/_/_____/____/_______| Dog");

                    WriteLine(@"



      |\      _,,,---,,_
ZZZzz /,`.-'`'    -.  ;-;;,_
     |,4-  ) )-,_. ,\ (  `'-'
    '---''(_/--'  `-'\_)  Cat");
                    WriteLine(@"



      /`·.¸
     /¸...¸`:·
 ¸.·´  ¸   `·.¸.·´)
: © ):´;      ¸  {
 `·.¸ `·  ¸.·´\`·¸)
     `\\´´\¸.·´ Fish


");
                    WriteLine("Which would you like!");
                    string answer = ReadLine();
                    Clear();
                    WriteLine("Why don't ya give it a name!");

                    if (answer.ToLower() == "dog")
                    {
                        
                        Dog dog = new Dog();
                        
                        dog.display();
                        dog.timedFatigue();
                        bool doggo = true;

                        //var periodicTimer = new PeriodicTimer(TimeSpan.FromSeconds(120));
                        //while (await periodicTimer.WaitForNextTickAsync())
                        {
                            dog.fatigue();
                            WriteLine("fatigue");
                        }

                        do
                        {

                            WriteLine(@"
                            ==============
                            |    Pet?    |
                            | Rub Belly? |
                            |   Play?    |
                            |    Feed?   |
                            |   Ignore?  |
                            |   Scold?   |
                            |   Remove?  | 
                            ==============");

                            string petAction = ReadLine();


                           
                            if (petAction.ToLower() == "pet")
                            {
                                Clear();
                                dog.pet();
                                dog.display();
                                
                            }
                            else if (petAction.ToLower() == "rub belly")
                            {
                                Clear();
                                dog.rubBelly();
                                dog.display();
                                
                            }
                            else if (petAction.ToLower() == "play")
                            {
                                Clear();
                                dog.play();
                                dog.display();
                                
                            }
                            else if (petAction.ToLower() == "feed")
                            {
                                Clear();
                                dog.feed();
                                dog.display();
                                
                            }
                            else if (petAction.ToLower() == "ignore")
                            {
                                Clear();
                                dog.ignore();
                                dog.display();
                                
                            }
                            else if (petAction.ToLower() == "scold")
                            {
                                Clear();
                                dog.scold();
                                dog.display();
                                
                            }
                            else if (petAction.ToLower() == "remove")
                            {
                                Clear();
                                doggo = false;
                                dog.tf = false;
                            }
                        } while (doggo == true);
                    }
                    else if (answer.ToLower() == "cat")
                    {

                        Cat cat = new Cat();
                        
                        cat.display();
                        cat.timedFatigue();
                        bool gato = true;

                        do
                        {


                            WriteLine(@"
                            ==============
                            |    Pet?    |
                            | Rub Belly? |
                            |   Play?    |
                            |    Feed?   |
                            |   Ignore?  |
                            |   Scold?   |
                            |   Remove?  | 
                            ==============");

                            string petAction = ReadLine();


                            
                            //int noPets = 0;
                            if (petAction.ToLower() == "pet")
                            {
                                Clear();
                                cat.pet();
                                cat.display();
                                
                                
                            }
                            else if (petAction.ToLower() == "rub belly")
                            {
                                Clear();
                                cat.rubBelly();
                                cat.display();
                                
                            }
                            else if (petAction.ToLower() == "play")
                            {
                                Clear();
                                cat.play();
                                cat.display();
                                
                            }
                            else if (petAction.ToLower() == "feed")
                            {
                                Clear();
                                cat.feed();
                                cat.display();
                                
                            }
                            else if (petAction.ToLower() == "ignore")
                            {
                                Clear();
                                cat.ignore();
                                cat.display();
                                
                            }
                            else if (petAction.ToLower() == "scold")
                            {
                                Clear();
                                cat.scold();
                                cat.display();
                                
                            }
                            else if (petAction.ToLower() == "remove")
                            {
                                Clear();
                                gato = false;
                                cat.tf = false;
                            }
                        } while (gato == true);
                    }
                    else if (answer.ToLower() == "fish")
                    {
                        Fish fish = new Fish();
                        
                        fish.display();
                        fish.timedFatigue();
                        bool pesco = true;

                        do
                        {


                            WriteLine(@"
                            ==============
                            |    Pet?    |
                            | Rub Belly? |
                            |   Play?    |
                            |    Feed?   |
                            |   Ignore?  |
                            |   Scold?   |
                            | tap glass? |
                            |    talk?   |
                            | play music?|
                            |   Remove?  | 
                            ==============");

                            string petAction = ReadLine();


                            

                            if (petAction.ToLower() == "pet")
                            {
                                Clear();
                                fish.pet();
                                fish.display();
                                
                            }
                            else if (petAction.ToLower() == "rub belly")
                            {
                                Clear();
                                fish.rubBelly();
                                fish.display();
                                
                            }
                            else if (petAction.ToLower() == "play")
                            {
                                Clear();
                                fish.play();
                                fish.display();
                                
                            }
                            else if (petAction.ToLower() == "feed")
                            {
                                Clear();
                                fish.feed();
                                fish.display();
                                
                            }
                            else if (petAction.ToLower() == "ignore")
                            {
                                Clear();
                                fish.ignore();
                                fish.display();
                                
                            }
                            else if (petAction.ToLower() == "scold")
                            {
                                Clear();
                                fish.scold();
                                fish.display();
                                
                            }
                            else if (petAction.ToLower() == "talk")
                            {
                                Clear();
                                fish.talk();
                                fish.display();
                            }
                            else if (petAction.ToLower() == "play music")
                            {
                                Clear();
                                fish.playMusic();
                                fish.display();
                            }
                            else if (petAction.ToLower() == "tap glass")
                            {
                                Clear();
                                fish.tapGlass();
                                fish.display();
                            }
                            else if (petAction.ToLower() == "remove")
                            {
                                Clear();
                                pesco = false;
                                fish.tf = false;
                            }
                        } while (pesco == true);
                    }
                

                    
                }
                else if (response.ToLower() == "q")
                {
                    active = false;            
                }


            } while (active);

           
            WriteLine("Press any key to exit.");
            ReadKey();
        }
    }
}