using recursion;
using TM.ProgrammingAdvanced;

namespace Recursion{
    internal class Program{
        static void Main(string[] args){
            //string folder = Data.Folders(@"./DataFolders");

            string folder = @"./DataFolders";

            FindKey keyfinder = new FindKey();

            Console.WriteLine("Key found! -->" + keyfinder.Algorithm1(folder) + " Count: " + keyfinder.count);


            keyfinder.count = 0;
            Console.WriteLine("Key found! -->" + keyfinder.Algorithm2(folder) + " Count " + keyfinder.count);

            Factorial factorial = new Factorial();
            Console.WriteLine("8! = " + factorial.Iterative(8));

            Console.WriteLine("8! = " + factorial.Iterative(8));
        }
    }
}