using System;
namespace Module_03{
    internal class Program{
        static void Main(string[] args){ 

            Assignment assignment = new Assignment();

            string input = Console.ReadLine();
            try{
            Console.WriteLine(assignment.Balance(input));
            }
            catch(Exception e){
                Console.WriteLine(e);
            }
        }
    }
}