using System;

namespace Module_11{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Assignment assignment = new Assignment();

                string input = Console.ReadLine().ToUpper().Trim(); 
                
                assignment.Decrypt(input);
            }
            catch{
                Console.WriteLine("Crazy input!");
            }
        }

    }
}

