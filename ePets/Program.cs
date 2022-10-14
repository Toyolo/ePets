using System;
using static System.Console; //to avoid using tedious typing
using System.Threading.Tasks;

namespace ePets
{
    class Program
    {
        static Pet pet;
        static Timer timer;

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
                        pet = new Dog();
                        DoPetAction();
                    }
                    else if (answer.ToLower() == "cat")
                    {
                        pet = new Cat();
                        DoPetAction();
                    }
                    else if (answer.ToLower() == "fish")
                    {
                        pet = new Fish();
                        DoPetAction();                        
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

        static void DoPetAction()
        {
            timer = new Timer(FeedPets, null, TimeSpan.Zero, TimeSpan.FromMinutes(1));
            pet.display();           


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
                    pet.pet();
                    pet.display();

                }
            else if (petAction.ToLower() == "rub belly")
                {
                    Clear();
                    pet.rubBelly();
                    pet.display();

                }
            else if (petAction.ToLower() == "play")
                {
                    Clear();
                    pet.play();
                    pet.display();

                }
            else if (petAction.ToLower() == "feed")
                {
                    Clear();
                    pet.feed();
                    pet.display();

                }
            else if (petAction.ToLower() == "ignore")
                {
                    Clear();
                    pet.ignore();
                    pet.display();

                }
            else if (petAction.ToLower() == "scold")
                {
                    Clear();
                    pet.scold();
                    pet.display();

                }
            else if (petAction.ToLower() == "talk")
                {
                    Clear();
                    pet.talk();
                    pet.display();
                }
            else if (petAction.ToLower() == "play music")
                {
                    Clear();
                    pet.playMusic();
                    pet.display();
                }
            else if (petAction.ToLower() == "tap glass")
                {
                    Clear();
                    pet.tapGlass();
                    pet.display();
                }
            else if (petAction.ToLower() == "remove")
            {
                Clear();                    
            }
        }

        static void FeedPets(object state)
        {
            Clear();
            pet.fatigue();
            pet.display();

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
        }
    }
}