using System.Runtime.ExceptionServices;

namespace Module_08{
    internal class Program{
        static void Main(string[] args){

            try{
                Assignment assignment = new Assignment();
                Console.WriteLine(assignment.checkCyclic());
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}