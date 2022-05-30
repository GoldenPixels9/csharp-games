
using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    public class Words{

        private List<String> wordList = new List<String>{"apple", "ironman", "cube", "paradox", "twenty", "lightswitch", "paradigm", "Cow", "First",
        "Lion", "Giant", "Frozen", "Olaf", "Mouse", "Grandma", "The", "Quick", "Brown", "Fox", "Jumped", "Over", "The", "Lazy", "Brown", "Bear", "Scout",
        "is", "Trustworthy", "Loyal", "Helpful", "Kind", "Thrifty"};

        private TerminalService terminalservice = new TerminalService(); 
        private string secretWord = "";
        private char[] guessedWord;
        
        public Words()
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

        public int upateGuessedWord(char letterGuess, int lives)
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

        public void printGuessedWord()
        {
            Console.WriteLine(guessedWord);
        }

        public bool winCheck() {
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