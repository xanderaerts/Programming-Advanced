using System;
namespace Module_07{
    internal class Program{
        static void Main(string[] args){

            try{
                int input = Int32.Parse(Console.ReadLine());
                
                if(input < 0) throw new Exception();

                Assignment assignment = new Assignment();
                Console.WriteLine(assignment.Sum(input));
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}