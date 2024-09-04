using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * HelloDungeon should have:
 * - Use of variables
 * - Use of functions
 * - Use of a struct
 * - Use of a function overload
 * 
 * In addition:
 * - Follow proper naming convention
 * - Your project should run with no errors (warnings are ok)
 * - Your code should be commented to a reasonable standard
 */

namespace HelloDungeon
{
    internal class Game
    {
        struct Player
        {
            public string name;
            public float health;
            public float mana;
            public float stamina;
            public int gold;
            public string role;

            public Player(
                string name,
                float health,
                float mana,
                float stamina,
                int gold,
                string role)
            {
                this.name = name;
                this.health = health;
                this.mana = mana;
                this.stamina = stamina;
                this.gold = gold;
                this.role = role;
            }
        }

        public void Run()
        {
            // Declare the player and assigning values
            Player player1 = new Player("Player 1", 0, 0, 0, 0, "None");

            // Get the player's name
            Console.WriteLine("What is your name?");
            Console.Write("> ");
            player1.name = Console.ReadLine();

            // Get the player's role and set stats
            int input = GetInput("Are you a warrior or a wizard?", "Warrior", "Wizard");
            if (input == 1)
            {
                player1.role = "Warrior";
                player1.health = 100;
                player1.mana = 20;
                player1.stamina = 50;
            }
            else if (input == 2)
            {
                player1.role = "Wizard";
                player1.health = 50;
                player1.mana = 100;
                player1.stamina = 20;
            }

            // Print the player's stats
            PrintPlayerStats(player1);
        }

        /// <summary>
        /// Get input from the player as an integer. Loops until a valid input is given.
        /// </summary>
        /// <param name="description">Prints before the input request</param>
        /// <param name="option1">First option</param>
        /// <param name="option2">Second option</param>
        /// <returns>Always returns 1 or 2</returns>
        int GetInput(string description, string option1, string option2)
        {
            string input = "";
            int inputRecieved = 0;

            // Input loop
            while (inputRecieved != 1 && inputRecieved != 2)
            {
                // Print options
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.Write("> ");

                // Get input from player
                input = Console.ReadLine();

                // If player selected the first option
                if (input == "1" || input == option1)
                {
                    // Set inputRecieved to be the first option
                    inputRecieved = 1;
                }
                // Otherwise if the player selected the second option
                else if (input == "2" || input == option2)
                {
                    // Set inputRecieved to be the second option
                    inputRecieved = 2;
                }
                // If neither are true
                else
                {
                    // Display error message
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            return inputRecieved;
        }

        /// <summary>
        /// Get input from the player as an integer. Loops until a valid input is given.
        /// </summary>
        /// <param name="description">Prints before the input request</param>
        /// <param name="option1">First option</param>
        /// <param name="option2">Second option</param>
        /// <param name="option3">Third option</param>
        /// <returns>Always returns 1, 2, or 3</returns>
        int GetInput(string description, string option1, string option2, string option3)
        {
            string input = "";
            int inputRecieved = 0;

            // Input loop
            while (inputRecieved != 1 && inputRecieved != 2 && inputRecieved != 3)
            {
                // Print options
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.WriteLine("3. " + option3);
                Console.Write("> ");

                // Get input from player
                input = Console.ReadLine();

                // If player selected the first option
                if (input == "1" || input == option1)
                {
                    // Set inputRecieved to be the first option
                    inputRecieved = 1;
                }
                // Otherwise if the player selected the second option
                else if (input == "2" || input == option2)
                {
                    // Set inputRecieved to be the second option
                    inputRecieved = 2;
                }
                // Otherwise if the player selected the third option
                else if (input == "3" || input == option3)
                {
                    // Set inputRecieved to be the third option
                    inputRecieved = 3;
                }
                // If none are true
                else
                {
                    // Display error message
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            return inputRecieved;
        }

        /// <summary>
        /// Print the player's stats
        /// </summary>
        void PrintPlayerStats(Player player)
        {
            Console.WriteLine();
            Console.WriteLine(player.name + " Name:    " + player.name);
            Console.WriteLine(player.name + " Role:    " + player.role);
            Console.WriteLine(player.name + " Gold:    " + player.gold);
            Console.WriteLine(player.name + " Health:  " + player.health);
            Console.WriteLine(player.name + " Mana:    " + player.mana);
            Console.WriteLine(player.name + " Stamina: " + player.stamina);
        }
    }
}
