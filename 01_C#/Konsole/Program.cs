using System;

namespace Konsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Hello");
            Console.Beep();
            Console.BufferHeight = 200;
            Console.BufferWidth = 100;
            var cap = Console.CapsLock;
            Console.Clear();
            Console.CursorLeft = 10;
            Console.CursorSize = 100;
            Console.CursorTop = 10;
            Console.CursorVisible = true;
            Console.Equals(1, 2);
            var er = Console.Error;
            Console.In();
        }
    }
}
