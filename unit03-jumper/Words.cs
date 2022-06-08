
using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    public class Words{ //Words class handles and updates anything with the user letter guess, and the generated word.

        private List<String> wordList = new List<String>{"iron", "man", "totally", "cool"};

        private TerminalService terminalservice = new TerminalService(); 
        private string secretWord = "";
        private char[] guessedWord;
        
        public Words() //Initializes and generates a random word, stores it as an array of chars, and prints the guessed word out as only underscores
        {
            Random random = new Random();
            int num = random.Next(0, wordList.Count);
            secretWord = wordList[num];
            guessedWord = new char[secretWord.Length];

            for (int i = 0; i < secretWord.Length; i++) 
            {
                guessedWord[i] = '_';
                Console.Write(guessedWord[i]);
                Console.Write(" ");
            }
        }

        public int upateGuessedWord(char letterGuess, int lives) //updates the guessed word from the user input
        {
           for (int i = 0; i < secretWord.Length; i++)
           {
               if (letterGuess == secretWord[i]) 
               {
                   guessedWord[i] = letterGuess;
               }
           }

           for (int i = 0; i < secretWord.Length; i++)
           {
               if (letterGuess == secretWord[i]) 
               {
                  return lives;
               }
           }

           return lives = lives - 1;
        }

        public void printGuessedWord() //prints the guessed word.
        {
            for (int i = 0; i < secretWord.Length; i++) 
            {
                Console.Write(guessedWord[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        public bool winCheck() { //checks if the game is won, then returns it to whoever called the function
           for (int i = 0; i < secretWord.Length; i++)
           {
               if (guessedWord[i] == '_') 
               {
                  return false;
               }
           }
           return true;
        }
    }
}