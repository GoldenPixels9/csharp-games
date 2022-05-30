using System;

namespace unit03_jumper
{
    public class Director //Director Class
    {
        private bool isPlaying = true; //private game boolean to tell if game is in session
        private TerminalService terminalservice = new TerminalService(); //private object of the terminal service class.
        private Words word = new Words(); //creates the words object from the words class.
        private Jumper jumper = new Jumper(); //creates jumper object from the jumper class
        private char letterGuess; //stores the user letter guess in 'letterGuess'
        private int lives; //stores the lives variable from the jumper class in this
        

        public Director() //nothing initialized
        {
        }

        public void StartGame() //Starts the game
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }


        private void GetInputs() //Gets the letter guess from the user
        {
            Console.Write("Guess a letter [a-z]");
            letterGuess = Console.ReadLine()[0];
        }

        private void DoUpdates() //gets the lives variable from the jumper class, updates the lives in the jumper class
        {
            lives = jumper.returnLives();
            lives = word.upateGuessedWord(letterGuess, lives);
            jumper.updateLives(lives);
        }

        private void DoOutputs() //Outputs information based on the updated version of the game. 
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