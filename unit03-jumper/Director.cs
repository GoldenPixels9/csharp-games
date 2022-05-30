using System;

namespace unit03_jumper
{
    public class Director
    {
        private bool isPlaying = true; //private game boolean to tell if game is in session
        private TerminalService terminalservice = new TerminalService(); //private object of the terminal service class.
        private Words word = new Words();
        private Jumper jumper = new Jumper();
        private char letterGuess;
        private int lives;
        

        public Director()
        {
        }

        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }


        private void GetInputs()
        {
            Console.Write("Guess a letter [a-z]");
            letterGuess = Console.ReadLine()[0];
        }

        private void DoUpdates()
        {
            lives = jumper.returnLives();
            lives = word.upateGuessedWord(letterGuess, lives);
            jumper.updateLives(lives);
        }

        private void DoOutputs()
        {
            word.printGuessedWord();
            jumper.displayLives(lives);

            if (lives == 0) 
            {
                terminalservice.WriteText("Oh no! you lost!");
                isPlaying = false;
            } 

            bool win = word.winCheck();

            if (win){
                terminalservice.WriteText("Good Job! You win!");
                isPlaying = false;
            }

        }
    }
}