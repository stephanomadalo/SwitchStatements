using System;

namespace SwitchStatements 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What was your favorite school subject?");
            var answer = Console.ReadLine();

            switch (answer)
            {
                case "Math":
                    Console.WriteLine("Math is pretty cool");
                    break;
                case "Science":
                    Console.WriteLine("I love science :)");
                    break;
                case "Social Studies":
                    Console.WriteLine("Don't lie");
                    break;
                case "English":
                    Console.WriteLine("meh");
                    break;
                case "Phys Ed":
                    Console.WriteLine("Running laps sucked :'(");
                    break;
                default:
                    Console.WriteLine("I ain't heard of that one super chief");
                    break;
            }


        }
    }
}