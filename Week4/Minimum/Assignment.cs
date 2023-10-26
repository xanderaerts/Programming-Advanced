using System;
using System.Collections.Generic;
namespace Module_04 
{
    public class Assignment
    {
        public int Minimum(List<int> input, int i){
            if(i >= input.Count -1){
                return input[i];
            }

            int min = Minimum(input,i + 1);

            if(input[i] < min){
                return input[i];
            }
            else{
                return min;
            }
        }
        
    }
}
