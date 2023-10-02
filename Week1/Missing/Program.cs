using System;

namespace Missing 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a sorrted array of number");

            string input = Console.ReadLine();

            if(input == null){
                input = "empty";
            }

            string[] inputNumbersSplitted = input.Split(' ');
            List<int> inputNumbersInt = new List<int>();

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

            
        }
    }
}