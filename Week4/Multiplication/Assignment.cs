using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Module_03 
{
    public class Assignment
    {
        public int Multiplication(int[] input,int i){
            if(i >= 1){
                return input[i];
            }

            int sum = input[i] * Multiplication(input,i +1);
            return sum;

        }
    }
}
