using System;
namespace Module_08{
    internal class Program{
        static void Main(string[] args){

            try{
                Assignment assignment = new Assignment();
                assignment.start();
            }

            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}