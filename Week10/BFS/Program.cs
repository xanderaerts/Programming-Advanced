using System;

namespace Module_10{
    internal class Program{
        static void Main(string[] args){
            try{
                Assignment assignment = new Assignment();
                
                assignment.Start();
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}