using recursion;
using TM.ProgrammingAdvanced;

namespace Recursion{
    internal class Program{
        static void Main(string[] args){
            string folder = @"./brol";

            FindKey keyfinder = new FindKey();
            Console.WriteLine("Key found! -->", keyfinder.Algorithm1(folder) + "Count" + keyfinder.count);


            keyfinder.count = 0;
            Console.WriteLine("Key found! -->", keyfinder.Algorithm2(folder) + "Count" + keyfinder.count);

        }

    }
}