using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unit04.Game.Casting;
using Unit04.Game.Directing;
using Unit04.Game.Services;


namespace Unit04
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        private static int FRAME_RATE = 12; //frame rate
        private static int MAX_X = 900; //max screen size x? *
        private static int MAX_Y = 600; //max screen size y? *
        private static int CELL_SIZE = 15; //cell size for each block
        private static int FONT_SIZE = 15; //font size
        private static int COLS = 60; //columns
        private static int ROWS = 40; //rows
        private static string CAPTION = "Robot Finds Kitten"; // victory message
        private static string DATA_PATH = "Data/messages.txt"; // file path of the long list of random messages in the game
        private static Color WHITE = new Color(255, 255, 255); // the color white
        private static int DEFAULT_ARTIFACTS = 100; // minimum number of artifacts the game can have, which is 40


        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast(); //cast object, don't know what it does

            // create the banner
            Actor banner = new Actor(); //banner object
            banner.SetText(""); //empty text
            banner.SetFontSize(FONT_SIZE); //sets the font size to the constant font size
            banner.SetColor(WHITE); //sets the color to white
            banner.SetPosition(new Point(CELL_SIZE, 0)); //sets the position??? *
            cast.AddActor("banner", banner); // officially adds the actor??? *  

            // create the robot
            Actor robot = new Actor(); // robot object
            robot.SetText("#"); // The characters shape
            robot.SetFontSize(FONT_SIZE); //font size 15
            robot.SetColor(WHITE); //sets the color to white
            robot.SetPosition(new Point(MAX_X / 2, MAX_Y - 15)); //sets the position
            cast.AddActor("robot", robot); // officially adds the robot??? * 

            // create the artifacts
            Random random = new Random(); //random object
            for (int i = 0; i < DEFAULT_ARTIFACTS; i++)
            {
                int num = random.Next(0, 2);
                int value = 0;
                string text = "";

                if (num == 1) 
                {
                    text = "*";
                    value = 1;
                }
                
                else if (num == 0)
                {
                    text = "O";
                    value = -1;
                }
                int[] velocity_array = new int[] {1, 3, 5, 9};
                int x = random.Next(1, COLS);
                int y = random.Next(1, ROWS);
                Point position = new Point(x, y);
                Point velocity = new Point(random.Next(-1, 1), velocity_array[random.Next(0, 3)]);
                position = position.Scale(CELL_SIZE);

                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);
                Color color = new Color(r, g, b);

                Artifact artifact = new Artifact();
                artifact.SetVelocity(velocity);
                artifact.SetText(text);
                artifact.SetFontSize(FONT_SIZE);
                artifact.SetColor(color);
                artifact.SetPosition(position);
                artifact.SetMessage(value);
                cast.AddActor("artifacts", artifact);
            }

            // start the game
            KeyboardService keyboardService = new KeyboardService(CELL_SIZE);
            VideoService videoService = new VideoService(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
            Director director = new Director(keyboardService, videoService);
            director.StartGame(cast);

            // test comment
        }
    }
}