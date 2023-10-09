using System;

namespace Module_01 
{
    internal class Assignment
    {
        public string inputStr { get; set; }

        public string Duplicates(string start,string filename)
        {
            string[] array = File.ReadAllLines(filename);


            List<string> matches = new List<string>();

            int inputStrLenght = start.Length, 
                low = 0, 
                high = array.Length - 1,
                posFirst=0, 
                diff = array[0].Length - start.Length;

            string newInput = start;

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
            string firstChar = array[j].Substring(0, start.Length);

            while (firstChar == start) { 
            if (firstChar == start) {
                matches.Add(array[j]);
            }
                j++;
                firstChar = array[j].Substring(0, inputStrLenght);
            } 
                
            if (matches.Count > 0)
            {
                return string.Join(" ", matches);
            }
            else {
                
                return "No duplicates found.";
            }

        }
    }
}