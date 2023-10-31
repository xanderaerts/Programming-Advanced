using System;

namespace BackTracking{
    class Program{
        static void Main(string[] args){

            NQueens nQueens = new NQueens(10);


            nQueens.Solve(0);
            
           // Console.WriteLine(nQueens);

            Subset subset = new Subset();

            List<List<int>> results =  subset.Solve(new int[]{1,2,3,4});
            List<List<int>> results2 = subset.SolveBinary(new int[]{4,8,10,489,44,45});

            foreach(var item in results){
                Console.WriteLine(string.Join(" ",item));
            }

            foreach(var item in results2){
              //  Console.WriteLine(string.Join(" ",item));
            }

        }
    }
}

