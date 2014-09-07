using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCombatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WindowWidth = 160;
            Console.WindowHeight = 50;
            Console.WindowLeft = 0;

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



                                                                                                                        again.
                   ");
            string name;
            // Ask user to enter their name
            Console.Write("What's your name? ");
            // Console reads the name and prints it out
            name = Console.ReadLine();
            Console.WriteLine
                (@"
Doctor: 'Well " + name + @", I have some good news and some bad news. 
The good news is you're immune to the virus. The bad news is the zombies can still kill you, 
and there's a horde about to break through that door behind you. Take this bag full of supplies, hopefully they'll help.'

You open the bag. There's grenades, a shotgun, and a full syringe marked 'adrenaline'.
The grenades are powerful, causing between 20 - 30 damage to the horde,  but there's only a 70% chance they work.
The shotgun works every time, but it's not as powerful, causing 10 - 15 damage to the horde.
The adrenaline will boost your health by 10 - 20 points.

Doctor: 'This horde is strong. If I were to rate their health on a scale of 1 - 200, I'd give them a 200.
That's about twice as much as you. I'll try to block the door so you can get a head start.'

The doctor tries to baracade the door, but it's too late. The zombies grab him and start to eat.

Doctor: 'RUN " + name + @"! RUN!!

You start running down the hall towards the hospital cafeteria, but the zombies are gaining on you. It's business time.

Press Enter
            ");
           
            Console.ReadLine();
            //call the dragon combat game
            DragonCombat();

            //keep the window open
            Console.ReadKey();
        }
        



        //Create a dragon combat simulator game. You start with 100 HP, the dragon starts with 200 HP. Game is over when either player has no more HP
        //There are 3 actions you can take as long as the game is still going.
        //Attack 1 has 70% chance of hitting, will cause between 20 - 35 damage to the dragon
        //Attack 2 has 100% chance of hitting, will cause between 10 - 15 damage to the dragon
        //Heal will heal the player between 10 - 20 HP
        //The dragon will always respond by attacking you, it has 80% chance of hitting, and will cause between 5 - 15 damage to player
        static void DragonCombat()
    {
        //delare variables for player HP, dragon HP
        int playerHP = 100;
        int dragonHP = 200;
        //create random number generator
        Random rng = new Random();
        //neither the player or the dragon have won yet
        bool won = false;
        bool lost = false;
        //create a while loop to run while still playing is true
            
        
            while (dragonHP > 0 && playerHP > 0 && !won && !lost)
        {
           


            //have the player choose attack 1, attack 2, or heal. declare your selection variables
            Console.WriteLine("Make your move. Throw a grenade (press 1), Fire your shotgun (press 2), Take the adrenaline (press 3)");
            string selectionString = Console.ReadLine();
            int selectionNum = int.Parse(selectionString);
                   
            //if their selection is 1 
            if (selectionNum == 1)
	        {
		        //calculate their chance of hitting (70%)
                int playerHitChance = rng.Next(1, 101);
    
                //Attack 1 hits
                if (playerHitChance < 70)
                {
                    Console.WriteLine();
                    Console.WriteLine("The grenade hits the middle of the horde!");
                    //calculate the amount of damage(20 - 35 HP) to the dragon, display to player, subtract amount from dragon HP
                    int att1Dam = rng.Next(20, 36);
                    dragonHP = dragonHP - att1Dam;
                    Console.WriteLine();
                    Console.Write("You caused " + att1Dam + " damage to the zombie horde!");
                } 
                //didn't hit
                else
                {
                //tell the player they missed.
                    Console.WriteLine();
                    Console.WriteLine("The grenade fizzled out. It was a dud!");
                }
                
            }
            //else if their selection is 2
            else if (selectionNum == 2)
	        {
            //they hit, calculate the amount of damage(10 - 15 HP) to the dragon, display to player, subtract the amount from dragon HP
                int att2Dam = rng.Next(10,16);
                dragonHP = dragonHP - att2Dam;
                Console.WriteLine();
                Console.WriteLine("You blasted the zombies with your shotgun, and caused " + att2Dam + " damage to the horde!");
            }
            //else if their selection is 3, 
            else if (selectionNum == 3)
            {
            //calculate the amount they've healed(10 - 20 HP), display to player, add the amount to player HP
                int playerHeal = rng.Next(10, 21);
                playerHP = playerHP + playerHeal;
                Console.WriteLine();
                Console.WriteLine("You plunge the syringe into your heart, and heal " + playerHeal + " points.");
            }
            else if (selectionNum == 9)
            {
                dragonHP = dragonHP - 200;
                Console.WriteLine();
                Console.WriteLine("You realize that you're Superman, and take out the entire zombie horde with your heat vision.");
            }

            if (dragonHP > 0)
            {

             
                //Dragon's turn - calculate the dragons chance of hitting (80%)
                int dragonHitChance = rng.Next(1, 101);
            //dragon hit
            if (dragonHitChance < 80)
            {
                //calculate the amount of damage(5 - 15 HP) to the player, display to the player, subtract amount from player HP
                int dragDam = rng.Next(5, 16);
                playerHP = playerHP - dragDam;
                Console.WriteLine();
                Console.Write("The zombies grab you and take a bite for " + dragDam + " damage!");
                Console.WriteLine();
            }
            //dragon missed
            else
            {
                //tell the player the dragon missed.
            Console.WriteLine("The zombies slash at you, but miss!");
            }
            }
            else
            {

            }
            Console.WriteLine();
            Console.WriteLine("Your Health:  " + playerHP); 
            Console.WriteLine("Horde Health: " + dragonHP);
            Console.WriteLine();


        }
            //the game is won when the dragon has 0 or less HP, the game is lost when the player has 0 or less HP
            if (dragonHP <= 0)
            {
                won = true;
                //tell the user they won
                Console.WriteLine("You decimated the zombie horde... this time.");
            }
            else if (playerHP <= 0)
            {
                lost = true;
                //tell the loser they lost
                Console.WriteLine("You've been devoured by the zombie horde, and since you're immune to the virus, you're really dead.");
        }

    }

    }


    }


