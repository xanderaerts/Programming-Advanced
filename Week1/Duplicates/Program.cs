using System;
namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Assignment dp = new Assignment();


            string inputStr = Console.ReadLine();

            while (string.IsNullOrEmpty(inputStr))
            {
                Console.Clear();
                Console.WriteLine($"Crazy input!");

                inputStr = Console.ReadLine();
            }

        

           Console.WriteLine(dp.Duplicates(inputStr,"words.txt"));

            
        }
    }
}