using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Wally{
    internal class Program{
        static void Main(string []args){


            Sorting sort = new Sorting();
            Search search = new Search();

            var watch = new System.Diagnostics.Stopwatch();


            string[] inputList = File.ReadAllLines("names.txt");

            watch.Start();
            string[] sortedList = sort.CycleSort(inputList);
            watch.Stop();

            Console.WriteLine($"Cycle sort: {sort.counter}");
            Console.WriteLine($"Time: {watch.ElapsedMilliseconds}");
            Console.WriteLine($"Wally was found on row: {search.SearchWally(sortedList)}");

            inputList = File.ReadAllLines("names.txt");
            watch.Start();
            string[] sortedList2 = sort.ShellSort(inputList);
            watch.Stop();
            Console.WriteLine($"Shell sort: {sort.counter}");   
            Console.WriteLine($"Time: {watch.ElapsedMilliseconds}");
            Console.WriteLine($"Wally was found on row: {search.SearchWally(sortedList2)}");
                
        }
    }
}
