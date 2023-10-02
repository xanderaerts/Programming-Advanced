using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicates
{
    internal class Duplicates
    {
        public string inputStr { get; set; }

        public List<string> findDubble(string[] array, string inputStr)
        {
            List<string> matches = new List<string>();

            int inputStrLenght = inputStr.Length, 
                low = 0, 
                high = array.Length - 1,
                posFirst=0, 
                diff = array[0].Length - inputStr.Length;

            string newInput = inputStr;

            for (int i = 0; i < diff; i++) {
                newInput = newInput + "A";
            }
     
            while (low <= high) {
                int mid = (low + high) / 2;
                                          
                if (newInput.CompareTo(array[mid]) < 0)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }

                if (high <=1) {
                    break;
                }

                   posFirst = low;
            }

            int j = posFirst;
            string firstChar = array[j].Substring(0, inputStrLenght);

            while (firstChar == inputStr) { 
            if (firstChar == inputStr) {
                matches.Add(array[j]);
            }
                j++;
                firstChar = array[j].Substring(0, inputStrLenght);
            } 
                
            if (matches.Count > 0)
            {
                return matches;
            }
            else {
                matches.Add("no match");
                return matches;
            }

        }
    }
}