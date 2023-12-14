using System;
using System.Collections.Generic;
using System.Linq;
namespace Module_06 
{
    public class Assignment
    {
        public string SearchWords(string[] words,string input){
            List<string> output = new List<string>();
            List<string> subs = MakeSubs(input);

            foreach(string w in subs){
                if(words.Contains(w)) output.Add(w); 
            }

            output.Sort();
            return string.Join(" ",output);

        }
        List<string> MakeSubs(string input)
        {
            List<string> subwords = new List<string>();

            if (input.Length == 0)
            {
                return subwords;
            }

            for (int i = 1; i < input.Length; i++)
            {
                string left = input.Substring(0, i);
                string right = input.Substring(i);

                if(left.Length > 1 && !subwords.Contains(left)) subwords.Add(left);
                if(right.Length > 1 && !subwords.Contains(right)) subwords.Add(right);

                List<string> lefts = MakeSubs(left);
                List<string> rights = MakeSubs(right);

                foreach (string w in lefts)
                {
                    if(w.Length > 1 && !subwords.Contains(w) ) subwords.Add(w);
                }

                foreach (string w in rights)
                {
                   if(w.Length > 1 && !subwords.Contains(w)) subwords.Add(w);
                }
            }

            return subwords;
        }
    }
}
