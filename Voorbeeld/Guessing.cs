using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld
{
    internal class Guessing
    {

        public int Guesses { get; set; }

        public int Linear(int[] array, int number)
        {

            this.Guesses = 0;

            for (int i = 0; i < array.Length; i++) {
                this.Guesses++;
                if (array[i] == number) {
                    return i;
                }
            }
            return -1;
        }

        public int Stupid(int[] array, int number) {

            this.Guesses = 0;

            List<int> guessed = new List<int>();

            Random random = new Random();

            do {


                int position = random.Next(0, array.Length);

                this.Guesses++;
                if (array[position] == number)
                {
                    return position;
                }
                else if (!guessed.Contains(position))
                {
                    guessed.Add(position);
                }




            } while (guessed.Count < array.Length);

            return -1;

        }

        public int Binary(int[] array, int number) {

            this.Guesses = 0;

            int low = 0;
            int high = array.Length -1 ;


            while (low <= high) {
                int mid = (low + high) / 2;

                this.Guesses++;

                if (array[mid] == number)
                {
                    return mid;
                }
                else if (number < array[mid])
                {
                    high = mid - 1;
                }
                else {
                    low = mid + 1;
                }
            }

            return -1;

        }

    }
}
