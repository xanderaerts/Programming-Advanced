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

            try
            {
                Console.WriteLine(dp.Duplicates(inputStr,"words.txt"));   
            }
            catch (Exception e)
            {
                
                Console.WriteLine($"Crazy input!");
            } 
                
                

            
        }
    }
}