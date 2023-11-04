using System;
using System.Security.AccessControl;

namespace Module_5{
    internal class Program{
        static void Main(string[] args){
            
            try{
               // MagicSquare magicSquare = new MagicSquare(Int32.Parse(Console.ReadLine()));
               MagicSquare magicSquare = new MagicSquare(3);
                magicSquare.Create(1,1,0);
                Console.WriteLine(magicSquare);
            }
            catch(Exception e){
                Console.WriteLine("Crazy input!" + e);
            }
        }
    }
}