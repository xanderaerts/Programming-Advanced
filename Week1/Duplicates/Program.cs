using System;
namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Assignment dp = new Assignment();

            Console.WriteLine($"Give some characters: ");

            string inputStr = Console.ReadLine();

            while (string.IsNullOrEmpty(inputStr))
            {
                Console.Clear();
                Console.WriteLine($"Input can't be empty... \n");
                Console.WriteLine($"Give some characters: ");

                inputStr = Console.ReadLine();
            }

           Console.WriteLine(dp.Duplicates(inputStr,"words.txt"));

            
        }
    }
}