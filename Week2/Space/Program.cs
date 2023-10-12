using System;

namespace Module_02{
    internal class Program{
        static void Main(string[] args){   

            Assignment assignment = new Assignment();

            string input = "",opslag="";

            do{
                input  = Console.ReadLine();

                if(!string.IsNullOrEmpty(input)){
                opslag += input;
                opslag += "\n";
                }

            }while(!string.IsNullOrWhiteSpace(input));
            
            try
            {
                Console.Write($"{assignment.Sapce(input)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);    
            }

        }
    }
}