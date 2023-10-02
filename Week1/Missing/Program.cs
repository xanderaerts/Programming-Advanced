using System;

namespace Missing 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbersInt = new List<int>();

            Missing missing = new Missing();

            Console.WriteLine("Give a sorrted array of number");


            string input = Console.ReadLine();
            string[] inputNumbersSplitted = input.Split(' ');

            foreach(string nr in inputNumbersSplitted){
                try{
                    int parsed = Int32.Parse(nr);
                    inputNumbersInt.Add(parsed);
                }
                catch{
                    Console.WriteLine("Somthing went wrong, you didn't give a number");
                    break;
                } 
            }


            int missingNumber = missing.findMissing(inputNumbersInt);

            if (missingNumber == -1)
            {
                Console.WriteLine($"No number missing");
            }
            else
            {
                Console.WriteLine($"{missingNumber}");
            }

            
        }
    }
}