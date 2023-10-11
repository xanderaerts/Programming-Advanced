using System; 
using System.Collections.Generic;
using System.IO;
    
namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Assignment dp = new Assignment();


            string inputStr = Console.ReadLine();
            inputStr = inputStr.ToLower();

            if(string.IsNullOrWhiteSpace(inputStr)){         
                Console.WriteLine($"Crazy input!");
                
            }
            else{
                Console.WriteLine(dp.Duplicates(inputStr,"words.txt"));
            }

            
        }
    }
}