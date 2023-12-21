using System;

namespace Module_11 {
    public class Program {
        static void Main(string[] args) {
            try {
                Assignment assignment = new Assignment();

                string one = Console.ReadLine().Trim();

                string two = Console.ReadLine().Trim();

                bool output = assignment.CheckSimilair(one, two);


                Console.WriteLine(output ? "True" : "false");

                
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}
