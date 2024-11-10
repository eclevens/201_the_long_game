using System;
using System.IO;
using System.Text;
namespace the_long_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //rubric check (for my own purposes)
            /*
             * Made a new VS project                                                        CHECK
             * Have the project be backed up with version control and stored on gitHub      CHECK
             * Commits are appropriately named.                                             CHECK
             * Collected the username from the user and stored it in a variable             CHECK
             * Increase points when a keypress is made                                      CHECK
             * Display the updated score after each keypress                                CHECK
             * When the player presses enter end the game                                   CHECK
             * Save the username and score variable data out to a file
             * Read from a file and store the username and score data into local variables
             * Appropriate comments                                                         CHECK
             */

            //variables

            //username storing variable
            string? username; //I searched online how to fix an error for: username = Console.ReadLine(); said to make string?
            //score storing variable. initialize to 0.
            int score = 0;

            //program START
            Console.WriteLine("Hello, welcome to the program.\nWhat is your name?");
            //User inputs name
            username = Console.ReadLine(); //I searched online how to fix an error for: username = Console.ReadLine(); see username declaration
            Console.WriteLine("Nice to meet you, " + username);

            //Save the username and score variable data out to a file
            string fileName = "The_Long_Game_" + username + ".txt";
            //check if user data exists
            //idk how to do this
            if (File.Exists(fileName))
            {
                string fileContent = File.ReadAllText(fileName);
                //pretend the file got read and exists
                //pretend there is code here that loads in the data from the txt
            }

            Console.WriteLine("Press any key to increase your score\nPress <enter> to quit");
            //game START
            //increase points when a key press is made
            while (true)
            {
                //if key pressed
                if (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    //increase score by 1
                    score++;
                    //display the updated score
                    Console.WriteLine("\nScore: " + score);
                }
                //pressing enter quits the game
                else if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    break;
                }
            }//end game loop
            Console.WriteLine("Thank you for playing, " + username + "\nYour final score: " + score);
            //Save the username and score variable data out to a file
            //used microsoft resources for io since I missed class and slides/text were not helpful :(
            string content = username + "\n" + score;
            File.WriteAllText(fileName, content);
            Console.WriteLine("Your score has been saved to: " + fileName);
        }
    }
}