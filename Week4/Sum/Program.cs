using System;

namespace Module_03{
    internal class Program{
        static void Main(string[] args){
            string input = Console.ReadLine();

            Assignment assingement = new Assignment();

            try{
                Console.WriteLine(assingement.Sum(input));
            }
            catch{
                Console.WriteLine("Crazy input!");
            }


        }
    }
}