using System;

namespace unit02_hilo
{
    class Deck
    {
        public Deck()
        {
        }
        
        public int numberGenerator() {
            Random random = new Random();
            int num = random.Next(1, 13);
            return num;
        }
    }
}