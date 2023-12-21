using System;

namespace Module_11{
class Program
    {
        static void Main(string[] args)
        {

            try{

            Assignment assignment = new Assignment();

            string input = Console.ReadLine().Trim();

            int amount = Int32.Parse(Console.ReadLine());

            assignment.FindMissing(input,amount);
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}
