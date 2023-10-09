using System.Runtime.CompilerServices;

namespace Voorbeeld {
    internal class Program {
        static void Main(string [] args) {
            int[] array = Array.ConvertAll(File.ReadAllLines("sorted_numbers.txt "), Int32.Parse);

            Guessing guess = new Guessing();
            
            int number = 36;

            Console.WriteLine($"LINEAR {number} position {guess.Linear(array, number)} - guesses {guess.Guesses}");
            Console.WriteLine($"Stupid {number} position {guess.Stupid(array, number)} - guesses {guess.Guesses}");
            Console.WriteLine($"Binary {number} position {guess.Binary(array, number)} - guesses {guess.Guesses} \n");

            number = 37;

            Console.WriteLine($"LINEAR {number} position {guess.Linear(array, number)} - guesses {guess.Guesses}");
            Console.WriteLine($"Stupid {number} position {guess.Stupid(array, number)} - guesses {guess.Guesses}");
            Console.WriteLine($"Binary {number} position {guess.Binary(array, number)} - guesses {guess.Guesses} \n");


            number = 998;

            Console.WriteLine($"LINEAR {number} position {guess.Linear(array, number)} - guesses {guess.Guesses}");
            Console.WriteLine($"Stupid {number} position {guess.Stupid(array, number)} - guesses {guess.Guesses}");
            Console.WriteLine($"Binary {number} position {guess.Binary(array, number)} - guesses {guess.Guesses}\n");

            number = -1000;

            Console.WriteLine($"LINEAR {number} position {guess.Linear(array, number)} - guesses {guess.Guesses}");
            Console.WriteLine($"Stupid {number} position {guess.Stupid(array, number)} - guesses {guess.Guesses}");
            Console.WriteLine($"Binary {number} position {guess.Binary(array, number)} - guesses {guess.Guesses}\n");
        }
    }
}