using System;

namespace unit02_hilo
{
    class Director
    {
        public void runGame() {
            int score = 300;

            while (score > 0) {

                //random object and number generators
                Deck deck = new Deck();
                int secretNumber = deck.numberGenerator();
                int publicNumber = deck.numberGenerator();

                //user input
                Console.WriteLine("The card is: " + publicNumber);
                Console.Write("Higher or Lower? (h/l): ");
                string input = Console.ReadLine();

                if (input == "h" && secretNumber >= publicNumber) {
                    score += 100;
                } 
                else if (input == "l" && secretNumber <= publicNumber){
                    score += 100;
                }
                else if ((input == "h" || input == "l") && secretNumber == publicNumber) {
                    score += 0;
                }
                else {
                    score -= 75;
                }

                Console.WriteLine("You're next card was: " + secretNumber);
                Console.WriteLine("Your score is: " + score);
                Console.WriteLine();


                if (score <= 0) {

                    Console.Write("Play Again? (y/n)");
                    string playAgain = Console.ReadLine();
                    Console.WriteLine();
                    
                    if (playAgain == "y") {
                        score = 300;
                    } 
                    
                    else if (playAgain == "n"){
                        break;
                    }
                }
                
            }
        }
    }
}
