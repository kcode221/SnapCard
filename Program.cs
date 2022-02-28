using System;

namespace card
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var snap = new Game("Player1", "Player2");
            snap.Start();
        }
    }
}
