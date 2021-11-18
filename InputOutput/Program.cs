using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            // let name = input.question("What is your name?");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}
