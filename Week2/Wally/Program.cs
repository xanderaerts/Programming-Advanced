using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Wally{
    internal class Program{
        static void Main(string []args){


            Sorting sort = new Sorting();
            Search search = new Search();


            string[] inputList = File.ReadAllLines("names.txt");
            string[] sortedList = sort.CycleSort(inputList);
            Console.WriteLine($"Cycle sort: {sort.counter}");
            Console.WriteLine($"Wally was found on row: {search.SearchWally(sortedList)}");


            inputList = File.ReadAllLines("names.txt");
            string[] sortedList2 = sort.ShellSort(inputList);
            Console.WriteLine($"Shell sort: {sort.counter}");       
            Console.WriteLine($"Wally was found on row: {search.SearchWally(sortedList2)}");
                
        }
    }
}
