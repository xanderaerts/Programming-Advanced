using System.Data.Common;
using System.Linq.Expressions;

namespace Module_07{
    internal class Program{
        static void Main(string[] args){
            

            try{
                int input = Int32.Parse(Console.ReadLine());
                Assignment assignment = new Assignment(input);
                Console.WriteLine(assignment.findBiggest());
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}

