using System;
namespace Duplicates
{
    internal class Program {
        static void Main(string[] args) {

            string[] array = File.ReadAllLines("words.txt");

            Duplicates dp = new Duplicates();

            Console.WriteLine($"Give some characters: ");

            string inputStr = Console.ReadLine();

            while (string.IsNullOrEmpty(inputStr))
            {
                Console.Clear();
                Console.WriteLine($"Input can't be empty... \n");
                Console.WriteLine($"Give some characters: ");

                inputStr = Console.ReadLine();
            }

            List<string> doubles = dp.findDubble(array, inputStr);

            for (int i = 0; i < doubles.Count; i++) {
                Console.WriteLine($"{doubles[i]}");
            }
        }
    }
}