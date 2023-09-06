using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloDungeon
{
    class Game
    {

        //Initializes player stats.
        string playerName = "";
        string playerChoice = "";
        float playerDamage = 3.2f;
        float playerHealth = 100.0f * 2;
        float playerStrength = 10;
        int currentScene = 2;
        bool gameOver = false;

        //Initialize weapon stats.
        float swordDamage = 10.0f;
        float boardDamage = 1.0f;
        float bowThatShootsPipesDamage = 800.0f;

        float Add(float a, float b)
        {
            float result = a + b;
            return result;
        }

        void PrintStats(string name, float health, float damage, float strength)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Damage: " + damage);
            Console.WriteLine("Strength: " + strength);
        }

        int GetGreaterNumber(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }

        void CountTo(int end)
        {
            for (int count = 0; count <= end; count++)
            {
                Console.WriteLine(count);
            }
        }

        void PrintAllEvens(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        string DisplayMenu(string prompt, string option1, string option2, string option3)
        {
            string playerChoice = "";

            while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
            {
                //Display prompt.
                Console.Clear();
                Console.WriteLine(prompt);

                //Display all options.
                Console.WriteLine("1." + option1);
                Console.WriteLine("2." + option2);

                if (option3 != "")
                {
                    Console.WriteLine("3." + option3);
                }

                //Get player input.
                Console.Write("> ");
                playerChoice = Console.ReadLine();

                //If the player input is not one of the available options...
                if (playerChoice != "1" && playerChoice != "2")
                {
                    if (playerChoice == "3" && option3 != "")
                    {
                        continue;
                    }

                    //...display the error message.
                    Console.Clear();
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);
                    playerChoice = "";
                }
            }

            return playerChoice;
        }

        void DisplayMainMenu()
        {
            Console.Clear();
            playerChoice = "";

            //Main menu
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

            playerChoice = DisplayMenu("Choose your weapon", "Sword of the Ancients", "Frog with Gun", "Wompus");


            if (playerChoice == "1")
            {
                playerDamage = swordDamage;
            }
            else if (playerChoice == "2")
            {
                playerDamage = boardDamage;
            }
            else if (playerChoice == "3")
            {
                playerDamage = bowThatShootsPipesDamage;
            }

            PrintStats(playerName, playerHealth, playerDamage, playerStrength);


            //Pauses the game.
            Console.WriteLine("Press any key to continue.");
            char character = Console.ReadKey(true).KeyChar;
            Console.WriteLine(character);

            currentScene = 1;
        }

        void DisplayScene1()
        {
            //Display context for decision.
            Console.WriteLine("You run into a mysterious old man on your journey.");
            Console.WriteLine("He offers you a weird bottle of kinda stinky liquid");
            Console.WriteLine("You take it in your hand and you feel that the bottle is sticky as well.");

            //Symbol to show the player we expect input
            Console.Write("> ");

            //Pauses the game.
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            //Take in player's input.
            playerChoice = DisplayMenu("'If you you you ingest this great elixir you will find yourself \n" +
                "with more power than could ever imagine dragons. \n Do you drink the strange liquid?",
                "Yes", "No", "Return to Main Menu");

            //Display text based on players decision.
            if (playerChoice == "1" || playerChoice == "Yes")
            {
                Console.WriteLine("The weird drink is oddly thick, but tastes like apples?");
                Console.WriteLine("You notice your skin starts to harden. You gain 1200 health.");

                playerHealth += 1200;
            }
            else if (playerChoice == "2" || playerChoice == "No")
            {
                Console.WriteLine("You go with your gut feeling and decline the old man's offer.");
                Console.WriteLine("The old man is offended at first but shrugs his shoulders in understand.");
                Console.WriteLine("You gain 8 wisdom. You lose 5 intelligence.");
            }
            else if (playerChoice == "3" || playerChoice == "Return to Main Menu")
            {
                currentScene = 0;
                return;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            currentScene = 2;
        }

        void DisplayScene2()
        {

            playerChoice = "";

            while (playerChoice != "1" && playerChoice != "2")
            {
                Console.WriteLine("That's it!  Wanna play again?");

                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                Console.Write("> ");

                playerChoice = Console.ReadLine();

                if (playerChoice == "2")
                {
                    gameOver = true;
                }
                else if (playerChoice == "1")
                {
                    currentScene = 1;
                    return;
                }
                Console.Clear();
            }
        }

        public void Run()
        {
            while (gameOver == false)
            {
                if (currentScene == 0)
                {
                    DisplayMainMenu();
                }
                else if (currentScene == 1)
                {
                    DisplayScene1();
                }
                else if (currentScene == 2)
                {
                    DisplayScene2();
                }
            }

        }
    }
}