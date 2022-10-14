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
                        ChoosePet(TimeSpan.FromMinutes(2));
                    }
                    else if (answer.ToLower() == "cat")
                    {
                        pet = new Cat();
                        ChoosePet(TimeSpan.FromMinutes(2));
                    }
                    else if (answer.ToLower() == "fish")
                    {
                        pet = new Fish();
                        ChoosePet(TimeSpan.FromMinutes(3));
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

        static void ChoosePet(TimeSpan time)
        {
            Clear();
            timer = new Timer(FeedPets, null, TimeSpan.Zero, time);
            var petco = true;
            pet.display();

            while(petco)
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
                    CheckIfStarved();

                }
                else if (petAction.ToLower() == "rub belly")
                {
                    CheckIfStarved();

                }
                else if (petAction.ToLower() == "play")
                {
                    CheckIfStarved();

                }
                else if (petAction.ToLower() == "feed")
                {
                    DoPetAction(pet.ignore);

                }
                else if (petAction.ToLower() == "ignore")
                {
                    CheckIfStarved();

                }
                else if (petAction.ToLower() == "scold")
                {
                    CheckIfStarved();

                }
                else if (petAction.ToLower() == "talk")
                {
                    CheckIfStarved();
                }
                else if (petAction.ToLower() == "play music")
                {
                    CheckIfStarved();
                }
                else if (petAction.ToLower() == "tap glass")
                {
                    CheckIfStarved();
                }
                else if(petAction.ToLower() == "remove")
                {
                    Clear();
                    petco = false;
                }
            }            
        }

        delegate void PetAction();
       
        static void DoPetAction(PetAction action)
        {
            Clear();            
            action();
            pet.display();
        }

        static void CheckIfStarved()
        {
            if (!pet.Starved || !pet.Unhappy)
            {
                DoPetAction(pet.pet);
            }
            else
            {
                Clear();
                pet.display();
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