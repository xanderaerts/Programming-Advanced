using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1
{
    internal class Duplicates
    {
        public string inputStr { get; set; }

        public List<string> findDubble(string[] array, string inputStr)
        {

            List<string> matches = new List<string>();

            for (int i = 0; i < array.Length; i++) {

                string firstChar = array[i].Substring(0, 2);


                if (firstChar == inputStr) {
                    matches.Add(array[i]);                    
                }            
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
