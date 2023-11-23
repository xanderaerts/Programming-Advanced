using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Module_07
{
    public class Assignment
    {

        public List<string> subs {get;set;}

        public Assignment(int input){
            string binary = Convert.ToString(input,2);

            this.subs = createSubs(binary);
        }

        public int findBiggest(int i = 0){
            
          //  if(input < 0) throw new Exception("");
            
         //   string binary = Convert.ToString(input,2);

            int biggest = 0;

            if(i >= this.subs.Count) return biggest;

            for(int j = 0; j < this.subs.Count; j++){
                if(this.checkPalindrome(this.subs[j])){

                    int intval = Convert.ToInt32(this.subs[j],2);

                    if(biggest < intval) biggest = intval;

                    //biggest = Math.Max(biggest,findBiggest(i + 1));
                }
            }


           // Console.WriteLine(biggest);

            return biggest;
        }

        
        public List<string> createSubs(string input){
            List<string> output = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j <= input.Length; j++)
                {
                    output.Add(input.Substring(i, j - i));
                }
            }

            return output;
        }

        public bool checkPalindrome(string input){
            //tring binary = Convert.ToString(input);
            string inputRev = new string(input.ToCharArray().Reverse().ToArray());

            if(input == inputRev)return true;

            return false;
        }    
    }
}
