using System;

namespace Occurences
{
    public class Assignment
    {
        public int Occurences(string getal, string[] input, int i = 0){
            if(i == input.Length ){
                return 0;
            }

            if(input[i].CompareTo(getal) == 0){
                return 1 + Occurences(getal,input,++i);
            }
            else{
                return 0 + Occurences(getal, input,++i);
            }

        }
    }
}
