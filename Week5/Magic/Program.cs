using System;
using System.Security.AccessControl;

namespace Module_05{
    internal class Program{
        static void Main(string[] args){
            
            try{
                int input = Int32.Parse(Console.ReadLine());
                if(input <= 2) throw new Exception();
                MagicSquare magicSquare = new MagicSquare(input);
                magicSquare.Create(1,1,0);
                Console.WriteLine(magicSquare);
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }
    }
}