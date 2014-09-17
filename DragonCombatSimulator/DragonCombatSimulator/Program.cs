using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCombatSimulator
{
    class Program
    {
        private static string name;
        static void Main(string[] args)
        {
            
            Console.WindowWidth = 160;
            Console.WindowHeight = 50;
            
            Console.Title = "Zombies Must Die...";

            //This is the description of the game, as well as the instructions for the player.
            Console.WriteLine
                (@"                   
                   //////////////   /|||||||\    ||||\   /|\   /||||  ||||||||||\\   ||||||   |||||||||||||     //|||||||||\\
                   \\\\\\\\\\\\/   |||||||||||   ||||\\ /|||\ /|||||  |||||||||||||  ||||||   |||||||||||||    ///|||||||||\\\
                           ////    ||||   ||||   |||||\\\|||///|||||  |||||     |||  ||||||   |||||||||||||   ////         \\\\
                          ////     ||||   ||||   ||||| \\\|/// |||||  |||||     |||  ||||||   |||||          /|||           \\\\
                         ////      ||||   ||||   |||||  \\|//  |||||  |||||    ///   ||||||   |||||          ||||           
                        ////       ||||   ||||   |||||   \|/   |||||  |||||   ///    ||||||   |||||          \|||
                       ////        ||||   ||||   |||||         |||||  |||||||||/     ||||||   |||||||||||     \\\||||||||||\\\
                      ////         ||||   ||||   |||||         |||||  |||||||||\     ||||||   |||||||||||      \\\||||||||||\\\
                     ////          ||||   ||||   |||||         |||||  |||||   \\\    ||||||   |||||                        ||||\
                    ////           ||||   ||||   |||||         |||||  |||||    \\\   ||||||   |||||                        |||||
                   ////            ||||   ||||   |||||         |||||  |||||     |||  ||||||   |||||           \\\\         ||||/   
                  ////             ||||   ||||   |||||         |||||  |||||     |||  ||||||   |||||||||||||    \\\\       /////     
                 /\\\\\\\\\\\\\\   |||||||||||   |||||         |||||  |||||||||||||  ||||||   |||||||||||||     \\\|||||||////           
                 \\\\\\\\\\\\\\/    \|||||||/    |||||         |||||  ||||||||||//   ||||||   |||||||||||||      \\|||||||/// 
                 
                                ||||\   /|\   /||||   |||||   |||||       //|||||||||\\       ||||||||||||||||||
                                ||||\\ /|||\ //||||   |||||   |||||      ///|||||||||\\\      ||||||||||||||||||
                                |||||\\\|||///|||||   |||||   |||||     ////         \\\\     ||||||||||||||||||
                                ||||| \\\|/// |||||   |||||   |||||    /|||           \\\\          ||||||      
                                |||||  \\|//  |||||   |||||   |||||    ||||                         ||||||
                                |||||   \|/   |||||   |||||   |||||    \|||                         ||||||
                                |||||         |||||   |||||   |||||     \\\||||||||||\\\            ||||||
                                |||||         |||||   |||||   |||||      \\\||||||||||\\\           ||||||
                                |||||         |||||   |||||   |||||                  ||||\          ||||||
                                |||||         |||||   |||||   |||||                  |||||          ||||||
                                |||||         |||||   |||||   |||||     \\\\         ||||/          ||||||
                                |||||         |||||   |||||\ /|||||      \\\\       /////           ||||||
                                |||||         |||||   |||||||||||||       \\\|||||||////            ||||||
                                |||||         |||||    \|||||||||/         \\|||||||///             ||||||

                                                ||||||||||||||\\      ||||||   |||||||||||||
                                                ||||||||||||||\\\     ||||||   |||||||||||||
                                                |||||       \\\\\\    ||||||   |||||||||||||
                                                |||||        \\\\\\   ||||||   |||||
                                                |||||         \||||   ||||||   |||||
                                                |||||          ||||   ||||||   |||||
                                                |||||          ||||   ||||||   ||||||||||
                                                |||||          ||||   ||||||   ||||||||||
                                                |||||         /||||   ||||||   |||||
                                                |||||        //////   ||||||   |||||
                                                |||||       //////    ||||||   |||||||||||||   /|||\   /|||\   /|||\
                                                ||||||||||||||///     ||||||   |||||||||||||   |||||   |||||   |||||
                                                ||||||||||||||//      ||||||   |||||||||||||   \|||/   \|||/   \|||/



                   ");

            // Ask user to enter their name
            Console.Write("What's your name? ");
            // Console reads the name and prints it out
            name = Console.ReadLine();
            

            //call the introinstruct()
            IntroInstruct();
            Console.WriteLine("Press Enter");
            Console.ReadLine();
            
            
            //call the dragon combat game
            ZombiesMustDie();



            //keep the console window open
            Console.ReadKey();
        }
        



        //Create a dragon combat simulator game. You start with 100 HP, the dragon starts with 200 HP. Game is over when either player has no more HP
        //There are 3 actions you can take as long as the game is still going.
        //Attack 1 has 70% chance of hitting, will cause between 20 - 35 damage to the dragon
        //Attack 2 has 100% chance of hitting, will cause between 10 - 15 damage to the dragon
        //Heal will heal the player between 10 - 20 HP
        //The dragon will always respond by attacking you, it has 80% chance of hitting, and will cause between 5 - 15 damage to player
        static void ZombiesMustDie()
    {
        //delare variables for player HP, dragon HP
        int playerHP = 100;
        int hordeHP = 200;
        
        //let's keep track of how many times an attack or heal is used
        int att1Count = 0;
        int att2Count = 0;
        int healCount = 0;

        //create random number generator
        Random rng = new Random();
        //neither the player or the dragon have won yet
        bool won = false;
        bool lost = false;

        
        //create a while loop to run while still playing is true
            while (hordeHP > 0 && playerHP > 0 && !won && !lost)
        {
            Console.Clear();
            //player stats bar
            Console.WriteLine(@"_________________________________________________________________________________________________________________________________________________________

  " + name + @" Health     " + playerHP + "/100                                                                                                    Horde Health     " + hordeHP + @"/200
_________________________________________________________________________________________________________________________________________________________");
            Console.WriteLine();
            //have the player choose attack 1, attack 2, or heal. declare your selection variables
            Console.WriteLine("Make your move. Throw a grenade (press 1), Fire your shotgun (press 2), Take the adrenaline (press 3)");
            string selectionString = Console.ReadLine();
                
                int selectionNum = int.Parse(selectionString);
                   
            //if their selection is 1 
            if (selectionNum == 1)
            {
                //there are only 6 grenades in the bag
                if (att1Count > 5)
                {
                    Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |");
                    Console.WriteLine("  You can't find any more grenades. While you were looking through your bag, the zombies attack.");
                    Console.WriteLine("|________________________________________________________________________________________________________|");

                }
                else
                {
                    //calculate their chance of hitting (70%)
                    int playerHitChance = rng.Next(1, 101);

                    //Attack 1 hits
                    if (playerHitChance < 70)
                    {
                        //calculate the amount of damage(20 - 35 HP) to the dragon, display to player, subtract amount from dragon HP
                        int att1Dam = rng.Next(20, 36);
                        hordeHP = hordeHP - att1Dam;
                        Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |"); 
                        Console.WriteLine("  The grenade hits the middle of the horde, and causes " + att1Dam + " damage to the zombies!");
                        Console.WriteLine("|________________________________________________________________________________________________________|");

                    }
                    //didn't hit
                    else
                    {
                        //tell the player they missed.
                        Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |");
                        Console.WriteLine("  The grenade fizzled out. It was a dud!");
                        Console.WriteLine("|________________________________________________________________________________________________________|");

                    }
                    att1Count++;
                }
            }
            //else if their selection is 2
            else if (selectionNum == 2)
            {
                //calculate their chance of hitting (98%)
                int playerShotChance = rng.Next(1, 101);
                if (playerShotChance < 98)
                {
                    int playerCriticalChance = rng.Next(1, 101);
                    if (playerCriticalChance < 15)
                    {
                        //critical hit, causes 65 damage
                        int att2critDam = 65;
                        hordeHP = hordeHP - att2critDam;
                        Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |");
                        Console.WriteLine("  You blasted the zombies with your shotgun, and it was a CRITICAL HIT! Causing 65 damage to the horde!");
                        Console.WriteLine("|________________________________________________________________________________________________________|");

                        att2Count++;
                    }
                    else
                    {
                        //they hit, calculate the amount of damage(10 - 15 HP) to the dragon, display to player, subtract the amount from dragon HP
                        int att2Dam = rng.Next(10, 16);
                        hordeHP = hordeHP - att2Dam;
                        Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |");
                        Console.WriteLine("  You blasted the zombies with your shotgun, and caused " + att2Dam + " damage to the horde!");
                        Console.WriteLine("|________________________________________________________________________________________________________|");
                        att2Count++;
                    }
                }
                //didn't hit
                else
                {
                    //tell the player they missed.
                    Console.WriteLine(@" ___________________________________________________________________________________________________
|                                                                                                   |");
                    Console.WriteLine("  The shotgun misfired!");
                    Console.WriteLine("|___________________________________________________________________________________________________|");
                }
            }
            //else if their selection is 3, 
            else if (selectionNum == 3)
            {
                if (healCount > 4)
                {
                    Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |"); 
                    Console.WriteLine("  You can't find any more syringes. While you were looking through your bag, the zombies attack.");
                    Console.WriteLine("|________________________________________________________________________________________________________|");
                }
                else
                {
                    //calculate the amount they've healed(10 - 20 HP), display to player, add the amount to player HP
                    int playerHeal = rng.Next(10, 21);
                    playerHP = playerHP + playerHeal;
                    Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |");
                    Console.WriteLine("  You plunge a syringe into your heart, and heal " + playerHeal + " points.");
                    Console.WriteLine("|________________________________________________________________________________________________________|");

                    healCount++;
                }
            }
            else if (selectionNum == 9)
            {
                hordeHP = hordeHP - 200;
                Console.WriteLine(@" ___________________________________________________________________________________________________________________________________________
|                                                                                                                                           |"); 
                Console.WriteLine("  You realize that you're Superman, and take out the entire zombie horde with your heat vision. Wait, why did you let that doctor die?");
                Console.WriteLine("|___________________________________________________________________________________________________________________________________________|");

            }
            else
            {
                Console.WriteLine(@" ________________________________________________________________________________________________________
|                                                                                                        |"); 
                Console.WriteLine("  You froze. The zombies attack");
                Console.WriteLine("|________________________________________________________________________________________________________|");
            }
            if (hordeHP > 0)
            {

             
                //Horde's turn - calculate the horde chance of hitting (80%)
                int hordeHitChance = rng.Next(1, 101);
            //horde hit
            if (hordeHitChance < 80)
            {
                //calculate the amount of damage(5 - 15 HP) to the player, display to the player, subtract amount from player HP
                int dragDam = rng.Next(5, 16);
                playerHP = playerHP - dragDam;
                Console.WriteLine();
                Console.Write("The zombies grab you and take a bite for " + dragDam + " damage!");
                Console.WriteLine();
            }
            //horde missed
            else
            {
                //tell the player the horde missed.
                Console.WriteLine();
            Console.WriteLine("The zombies slash at you, but miss!");
            }
            }
            else
            {

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue.");
            Console.ReadKey();
        }
            //the game is won when the horde has 0 or less HP, the game is lost when the player has 0 or less HP
            if (hordeHP <= 0)
            {
                won = true;
                Console.WriteLine();
                //tell the user they won
                Console.WriteLine("You decimated the zombie horde... this time.");
                Console.WriteLine();
                Console.WriteLine(" Grenades thrown:    " + att1Count);
                Console.WriteLine(" Shells fired:       " + att2Count);
                Console.WriteLine(" Syringes emptied:   " + healCount);
            }
            else if (playerHP <= 0)
            {
                lost = true;
                Console.WriteLine();
                //tell the loser they lost
                Console.WriteLine("You've been devoured by the zombie horde, and since you're immune to the virus, you're really dead.");
                Console.WriteLine();
                Console.WriteLine(" Grenades thrown:    " + att1Count);
                Console.WriteLine(" Shells fired:       " + att2Count);
                Console.WriteLine(" Syringes emptied:   " + healCount);
            }


    }
        //Instructions function
        static void IntroInstruct()
        {
            Console.Clear();
            Console.WriteLine
                (@"
Doctor: 'Well " + name + @", I have some good news and some bad news. 
The good news is you're immune to the virus. The bad news is the zombies can still kill you, 
and there's a horde about to break through that door behind you. Take this bag full of supplies, hopefully they'll help.'

You open the bag. There are grenades, a shotgun, and a few syringes marked 'adrenaline'.
The grenades are powerful, causing between 20 - 30 damage to the horde,  but there's only a 70% chance they work.
The shotgun works every time, but it's not as powerful, causing 10 - 15 damage to the horde.
The adrenaline will boost your health by 10 - 20 points.

Doctor: 'This horde is strong. If I were to rate their health on a scale of 1 - 200, I'd give them a 200.
That's about twice as much as you. I'll try to block the door so you can get a head start.'

The doctor tries to baracade the door, but it's too late. The zombies grab him and start to eat.

Doctor: 'RUN " + name.ToUpper() + @"!! RUN!!!

You start running down the hall towards the hospital cafeteria, but the zombies are gaining on you. It's business time.

");
        }


    }


    }


