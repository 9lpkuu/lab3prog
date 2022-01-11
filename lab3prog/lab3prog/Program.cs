using System;

namespace lab3prog
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Point dot = new Point();
                dot.Draw(0, 0, '|');
                dot.Draw(1, 0, '+');
                dot.Draw(2, 0, '+');
                dot.Draw(0, 1, '|');
                dot.Draw(3, 1, '+');
                dot.Draw(0, 2, '|');
                dot.Draw(1, 2, '+');
                dot.Draw(2, 2, '+');
                dot.Draw(0, 3, '|');
            }
            catch
            {
                Environment.Exit(0);
            }
            Console.ReadKey();
        }
    }
}
