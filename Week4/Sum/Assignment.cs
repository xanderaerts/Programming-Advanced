using System;

namespace Module_03
{
    public class Assignment
    {
        public int Sum(string input,int i = 0){

            if( i == input.Length){
                return 0;
            }
            bool parse =  Int32.TryParse(input.Substring(i,1),out int output);
            if( !parse){
                return 0 + Sum(input,++i);
            }
            return Int32.Parse(input.Substring(i,1)) + Sum(input,++i);
        }
        
    }
}
