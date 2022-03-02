using System;

namespace Ytchallangearrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[2];

            Console.WriteLine("Type in stundents names: ");

            for (int i = 0; i < students.Length; i++)       
            {
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere are the names in alphabetic order: ");

            Array.Sort(students);

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
