using System;

namespace Module_01 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Assignment missing = new Assignment();

            string input = Console.ReadLine();
            string[] inputNumbersSplitted = input.Split(' ');

            int[] inputNumbersInt = new int[inputNumbersSplitted.Length];
            int i = 0;

                try{
                    foreach(string nr in inputNumbersSplitted){
                        int parsed = Int32.Parse(nr);
                        inputNumbersInt[i] = parsed;
                        i++; 
                    }  
                    
                    Console.WriteLine(missing.Missing(inputNumbersInt));
                }
                catch { 
                    Console.WriteLine("Crazy input!");
                }


            
        }
    }
}