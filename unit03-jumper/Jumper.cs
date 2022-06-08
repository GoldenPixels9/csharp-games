using System;

namespace unit03_jumper
{
    public class Jumper{ //Jumper class handles the lives of the jumper as well as printing his animation status
        public TerminalService terminalservice = new TerminalService();
        public int lives;
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
                terminalservice.WriteText("     ___     ");
                terminalservice.WriteText("   /_____\\  ");
                terminalservice.WriteText("   \\     /  ");
                terminalservice.WriteText("    \\   /   ");
            } 
            else if (lives == 3) 
            {
                terminalservice.WriteSpace();
                terminalservice.WriteText("   /_____\\  ");
                terminalservice.WriteText("   \\     /  ");
                terminalservice.WriteText("    \\   /   ");
            }
            else if (lives == 2)
            {
                terminalservice.WriteSpace();
                terminalservice.WriteText("   \\     /  ");
                terminalservice.WriteText("    \\   /   ");
            } 
            else if (lives == 1)
            {
                terminalservice.WriteSpace();
                terminalservice.WriteText("    \\   /   ");
            }

            if (lives > 0) 
            {
                terminalservice.WriteSpace();
                terminalservice.WriteText("      0   ");
                terminalservice.WriteText("     /|\\ ");
                terminalservice.WriteText("     / \\ ");
                terminalservice.WriteText("  ^^^^^^^^^ ");
            }
            else
            {
                terminalservice.WriteSpace();
                terminalservice.WriteText("      X   ");
                terminalservice.WriteText("     /|\\ ");
                terminalservice.WriteText("     / \\ ");
                terminalservice.WriteText("  ^^^^^^^^^ ");
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