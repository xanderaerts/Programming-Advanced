using System; 
namespace Module_02{
    internal class Program{
        static void Main(string[] args){

            string input = Console.ReadLine();

            Assignment assignment = new Assignment();

            Console.WriteLine(assignment.Largest(input));

        }

    }
}