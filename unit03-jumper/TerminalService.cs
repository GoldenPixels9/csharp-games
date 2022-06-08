using System;

namespace unit03_jumper
{
    public class TerminalService
    {
        public TerminalService()
        {
        }

        public int ReadNumber(string prompt)
        {
            string rawValue = ReadText(prompt);
            return int.Parse(rawValue, System.Globalization.CultureInfo.InvariantCulture);
        }

        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        public void WriteSpace()
        {
            Console.WriteLine();
        }

        public void WriteChar(char text)
        {
            Console.WriteLine(text);
        }

        public void WriteTextSameLine(string text)
        {
            Console.Write(text);
        }
    }
}