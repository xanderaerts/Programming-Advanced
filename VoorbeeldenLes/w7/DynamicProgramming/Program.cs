
using System.Threading.Tasks.Dataflow;

namespace DynamicProgramming{
    internal class Program{
        static void Main(string[] args){
            
            int n = 10;

            Fibonacci fibonacci = new Fibonacci();

           // Console.WriteLine("\n" + fibonacci.Recursion(n));
           // Console.WriteLine("\n" + fibonacci.Memoization(n, new int[n + 1]));
          //  Console.WriteLine("\n" + fibonacci.Tabulation(n));
          //  Console.WriteLine("\n" + fibonacci.Tabulation(n));


            n = 4;

            RotCutting rod = new RotCutting(new int[]{0,1,5,8,9,10,17,17,20,24,30});

           // Console.WriteLine(rod.Recursion(n));
            Console.WriteLine(rod.Memoization(n, new int[n+1]));
        }
    }
}