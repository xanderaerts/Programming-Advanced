using System;
namespace Module_09{
    internal class Program{
        static void Main(string[] args){

            try{
                Assignment assignment = new Assignment();
                assignment.start();
            }

            catch(Exception e){
                Console.WriteLine("Crazy input!" + e);
            }
        }
    }
}