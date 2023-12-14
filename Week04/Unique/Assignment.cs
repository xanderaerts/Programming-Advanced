using System;

namespace Module_03 
{
    public class Assignment
    {
        public string Unique(string input, int i = 0){
            if(i == input.Length - 1){
                return input.Substring(i,1);
            }
            if(input[i].CompareTo(input[i+1]) == 0 ){
                return  Unique(input,++i);                
            }
            else{
                return input.Substring(i,1) + Unique(input,++i);
            }

            
        }
    }
}
