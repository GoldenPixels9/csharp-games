using System;

namespace unit03_jumper
{
    public class Jumper{ //Jumper class handles the lives of the jumper as well as printing his animation status
        TerminalService terminalservice = new TerminalService();
        int lives;
        public Jumper() //initializes the lives, and displays them at the beginning of the game.
        {
            lives = 4;
            Console.WriteLine();
            Console.WriteLine();
            displayLives(lives);
        }

        public void displayLives(int lives) //displays the parachute at different levels based on the number of lives the player has.
        {
            if (lives == 4)
            {
                Console.WriteLine("     ___     ");
                Console.WriteLine("   /_____\\  ");
                Console.WriteLine("   \\     /  ");
                Console.WriteLine("    \\   /   ");
            } 
            else if (lives == 3) 
            {
                Console.WriteLine();
                Console.WriteLine("   /_____\\  ");
                Console.WriteLine("   \\     /  ");
                Console.WriteLine("    \\   /   ");
            }
            else if (lives == 2)
            {
                Console.WriteLine();
                Console.WriteLine("   \\     /  ");
                Console.WriteLine("    \\   /   ");
            } 
            else if (lives == 1)
            {
                Console.WriteLine();
                Console.WriteLine("    \\   /   ");
            }

            if (lives > 0) 
            {
                Console.WriteLine();
                Console.WriteLine("      0   ");
                Console.WriteLine("     /|\\ ");
                Console.WriteLine("     / \\ ");
                Console.WriteLine("  ^^^^^^^^^ ");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("      X   ");
                Console.WriteLine("     /|\\ ");
                Console.WriteLine("     / \\ ");
                Console.WriteLine("  ^^^^^^^^^ ");
            }
        }

        public int returnLives() //returns the amount of lives the player has
        {
            return lives;
        }

        public void updateLives(int updatedLives) //Updates the lives of this class so that this class can stay updated with whats going on.
        {
            lives = updatedLives;
        }
    }
}