using System;
using System.Collections.Generic;
using System.Linq;

namespace Module_11{
    public class Assignment
    {
        public void FindMissing(string input, int amount){
            string [] rawnumbs = input.Split(" ");

            List<int> numbs = new List<int>();

            List<int> missing = new List<int>();

            for(int i = 0; i < rawnumbs.Length; i++){
                numbs.Add(Int32.Parse(rawnumbs[i]));
            }

            numbs.Sort();

            int teller = 1, cur = numbs[0], prev = numbs[0];

            while (teller <= amount - 1 && teller <= numbs.Count ) {

               if (cur - prev > 1) missing.Add(prev + 1);

                if (teller < numbs.Count)
                {
                    cur = numbs[teller];
                    if (teller > 1) prev = numbs[teller - 1];
                }

                teller++;
            }

            if (numbs.Last() < amount) missing.Add(amount);



            if (missing.Count == 0) Console.WriteLine("No missing integers!");
            string s = "";
            foreach(var i in missing){
                s += i.ToString() + " "; 
            }

            s = s.Trim();
            
            Console.WriteLine(s);
        }
    }
}
