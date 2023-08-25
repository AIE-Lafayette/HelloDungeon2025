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
            //Initializes player stats.
            string playerName;
            string playerChoice;
            float damage = 3.2f;
            float health = 100.0f * 2;
            int areaNumber = 0;
            bool playerIsAlive = health > 0;

            //Initialize weapon stats.
            float swordDamage = 10.0f;
            float boardDamage = 1.0f;
            float bowThatShootsPipesDamage = 800.0f;

            Console.WriteLine("What is your name.");

            //Get player input for first and last character name.
            playerName = Console.ReadLine();

            //Display character name for player feedback.
            Console.WriteLine("Hello" + playerName);
            Console.WriteLine("Choose your weapon!");
            Console.WriteLine("1. Sword of the Ancients");
            Console.WriteLine("2. Wooden Board of the Home Depot");
            Console.WriteLine("3. Bow and Pipe");

            playerChoice = Console.ReadLine();

            //Set damage stat based on weapon selection.
            if (playerChoice == "1")
            {
                damage = swordDamage;
            }
            else if (playerChoice == "2")
            {
                damage = boardDamage;
            }
            else if (playerChoice == "3")
            {
                damage = bowThatShootsPipesDamage;
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
