namespace Wally{
    internal class Program{
        static void Main(string []args){
            
            string[] inputList = File.ReadAllLines("names.txt");

            Sorting sort = new Sorting();


            sort.CycleSort(inputList);
            Console.WriteLine($"Cycle sort: {sort.counter}");



        }
    }
}
