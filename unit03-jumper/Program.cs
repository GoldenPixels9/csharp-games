using System;

namespace unit03_jumper
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director(); //creates an instance of the director class
            director.StartGame(); //director instance uses the start game function from the director class
        }
    }
}
