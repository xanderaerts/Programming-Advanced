using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace Module_03 
{
    public class Assignment
    {
        public int Multiplication(string[] input,int i){
            if(i == input.Length){
                return 1;
            }
            if(i > 1){
                throw new Exception();
            }

            
            return Int32.Parse(input[i]) * Multiplication(input,++i);;

        }
    }
}
