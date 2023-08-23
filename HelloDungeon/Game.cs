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
            float damage = 3.2f;
            float health = 100.0f * 2;
            int areaNumber = 0;
            bool playerIsAlive = health > 0;

            //Print out name for first exercise.
            Console.WriteLine("Lodis");
            Console.WriteLine("Perkins");

            //Get player input for first and last character name.
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            playerName = firstName + lastName;

            //Display character name for player feedback.
            Console.WriteLine(playerName);

            //Display context for decision.
            Console.WriteLine("You run into a mysterious old man on your journey.");
            Console.WriteLine("He offers you a weird bottle of kinda stinky liquid");
            Console.WriteLine("You take it in your hand and you feel that the bottle is sticky as well.");

            Console.WriteLine("'If you you you ingest this great elixir you will find yourself");
            Console.WriteLine("with more power than you could imagine.'");

            
            Console.WriteLine("Do you drink the strange liquid?");

            //Display the player's choices.
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
            Console.WriteLine("3.Yeet it in his face");

            //Take in player's input.
            string playerChoice = Console.ReadLine();

            //Display text based on players decision.
            if (playerChoice == "1")
            {
                Console.WriteLine("The weird drink is oddly thick, but tastes like apples?");
                Console.WriteLine("You notice your skin starts to harden. You gain 1200 health.");

                health += 1200;
            }
            
            if (playerChoice == "2")
            {
                Console.WriteLine("You go with your gut feeling and decline the old man's offer.");
                Console.WriteLine("The old man is offended at first but shrugs his shoulders in understand.");
                Console.WriteLine("You gain 8 wisdom. You lose 5 intelligence.");
            }

            if (playerChoice == "3")
            {
                Console.WriteLine("The old man dodges at point blank range.");
                Console.WriteLine("He is not angry. He is just disappointed.");

                Console.WriteLine("His disappoinment hurts. Lose 5 health :(");

                health -= 5;
            }
        }
    }
}
