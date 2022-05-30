using System;

namespace unit03_jumper
{
    public class Jumper{
        TerminalService terminalservice = new TerminalService();
        int lives;
        public Jumper()
        {
            lives = 4;
            Console.WriteLine();
            Console.WriteLine();
            displayLives(lives);
        }

        public void displayLives(int lives)
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
                Console.WriteLine("      0   ");
                Console.WriteLine("     /|\\ ");
                Console.WriteLine("     / \\ ");
                Console.WriteLine("  ^^^^^^^^^ ");
            }
            else
            {
                Console.WriteLine("      X   ");
                Console.WriteLine("     /|\\ ");
                Console.WriteLine("     / \\ ");
                Console.WriteLine("  ^^^^^^^^^ ");
            }
        }

        public int returnLives()
        {
            return lives;
        }

        public void updateLives(int updatedLives) 
        {
            lives = updatedLives;
        }
    }
}