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
        }
    }
}
