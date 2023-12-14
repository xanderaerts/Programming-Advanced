using System;
using System.IO;
using System.Collections.Generic;

namespace Module_01 
{
    internal class Assignment
    {
        public string Duplicates(string start,string filename)
        {

            if(start == "" || start == null) throw new Exception("Crazy input!");

            start = start.ToLower();

            string[] array  = File.ReadAllLines(filename);
            
            List<string> res = new List<string>();
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
            string currentElement = array[j];
            string firstChar = currentElement.Substring(0, start.Length);

            while (firstChar == start && j < array.Length) { 

                if(res.Contains(currentElement)){
                    if (firstChar == start) {
                        matches.Add(currentElement);
                        j++;
                        firstChar = currentElement.Substring(0, inputStrLenght);
                    }   
                }
                else{
                    res.Add(currentElement);
                    j++;
                    firstChar = currentElement.Substring(0, inputStrLenght);
                }
                currentElement = array[j];
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