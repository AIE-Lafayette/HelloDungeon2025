using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {

            ///Add a loop in every instance where the player must make a decision.
            ///The loop should continue until the player gives a valid input.
            ///Place the entire game into a game loop. The player should
            ///be able to repeat the game as many times as they like.

            //Initializes player stats.
            string playerName = "";
            string playerChoice = "";
            float damage = 3.2f;
            float health = 100.0f * 2;
            float strength = 10;
            int areaNumber = 0;
            bool playerIsAlive = health > 0;

            //Initialize weapon stats.
            float swordDamage = 10.0f;
            float boardDamage = 1.0f;
            float bowThatShootsPipesDamage = 800.0f;

            while (playerChoice != "1")
            {
                Console.WriteLine("What is your name?");

                Console.Write("> ");
                //Get player input for character name.
                 playerName = Console.ReadLine();

                Console.WriteLine("Ah " + playerName + "! Am I pronouncing that correctly?");

                //Confirm the player name choice.
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");

                Console.Write(">");
                playerChoice = Console.ReadLine();

                Console.Clear();

                if (playerChoice == "1")
                {
                    //Display character name for player feedback.
                    Console.WriteLine("Nice to meet you " + playerName + "!");
                }
                else if (playerChoice == "2")
                {
                    Console.WriteLine("Sorry about that!");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey(true);
                }

            }

            //Create a variable to store whether or not we made a valid choice.
            bool weaponSelected = false;

            //Loop until a valid choice is given.
            while (weaponSelected == false)
            {
                //Display the options and option inputs.
                Console.WriteLine("Choose your weapon!");
                Console.WriteLine("1. Sword of the Ancients");
                Console.WriteLine("2. Wooden Board of the Home Depot");
                Console.WriteLine("3. Bow and Pipe");

                //Get the input from the player.
                playerChoice = Console.ReadLine();

                //Set damage stat based on weapon selection.
                if (playerChoice == "1")
                {
                    float scaledSwordDamage = swordDamage * strength;
                    damage = scaledSwordDamage;
                }
                else if (playerChoice == "2")
                {
                    damage = boardDamage;
                }
                else if (playerChoice == "3")
                {
                    damage = bowThatShootsPipesDamage;
                }

                //Reset input for the next menu.
                playerChoice = "";

                //Loop until a valid choice is given.
                while (playerChoice != "1" && playerChoice != "2")
                {
                    //Display choices.
                    Console.WriteLine("Are you sure you want this weapon?");
                    Console.WriteLine("1.Yes");
                    Console.WriteLine("2.No");

                    //Store player input.
                    Console.Write("> ");
                    playerChoice = Console.ReadLine();

                    //If the player has confirmed that they want the changes...
                    if (playerChoice == "1")
                    {
                        //...mark the input as valid.
                        weaponSelected = true;
                    }
                }

            }
            float enemyHealth = 100.0f;
            enemyHealth -= damage;

            Console.WriteLine("Damage is now " + damage);


            //Pauses the game.
            Console.WriteLine("Press any key to continue.");
            char character = Console.ReadKey(true).KeyChar;
            Console.WriteLine(character);


            //Display context for decision.
            Console.WriteLine("You run into a mysterious old man on your journey.");
            Console.WriteLine("He offers you a weird bottle of kinda stinky liquid");
            Console.WriteLine("You take it in your hand and you feel that the bottle is sticky as well.");

            //Symbol to show the player we expect input
            Console.Write("> ");

            //Pauses the game.
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            //Clears all text on the screen.
            Console.Clear();

            Console.WriteLine("'If you you you ingest this great elixir you will find yourself");
            Console.WriteLine("with more power than you could imagine.'");

            
            Console.WriteLine("Do you drink the strange liquid?");

            //Display the player's choices.
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
            Console.WriteLine("3.Yeet it in his face");

            //Take in player's input.
            playerChoice = Console.ReadLine();

            bool enemyAlive = true;

            if (playerIsAlive && enemyAlive)
            {
                //Perform battle logic
            }
            else
            {
                //Display battle results
            }


            //Display text based on players decision.
            if (playerChoice == "1" || playerChoice == "Yes")
            {
                Console.WriteLine("The weird drink is oddly thick, but tastes like apples?");
                Console.WriteLine("You notice your skin starts to harden. You gain 1200 health.");

                health += 1200;
            }
            else if (playerChoice == "2" || playerChoice == "No")
            {
                Console.WriteLine("You go with your gut feeling and decline the old man's offer.");
                Console.WriteLine("The old man is offended at first but shrugs his shoulders in understand.");
                Console.WriteLine("You gain 8 wisdom. You lose 5 intelligence.");
            }
            else if (playerChoice == "3" || playerChoice == "Yeet it in his face")
            {
                Console.WriteLine("The old man dodges at point blank range.");
                Console.WriteLine("He is not angry. He is just disappointed.");

                Console.WriteLine("His disappoinment hurts. Lose 5 health :(");

                health -= 5;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }


        }
    }
}