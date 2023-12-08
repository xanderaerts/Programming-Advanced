using System;

namespace Module_01
{
    public class Assignment
    { 
        public string Missing(int[] array){
            double missing = -1,sum = 0,expected = 0;

             for (int i = 0; i < array.Length; i++) {
                 sum += array[i];
             }


            int lenList =  (array[array.Length-1] - array[0]) + 1;

             expected = ((double)(lenList) / 2) * (array[0] + array[array.Length - 1]);


             missing = expected - sum;

             if (missing == 0)
             {
                 return "No missing number.";
             }
             else
             { return missing.ToString(); } 
        }
    }
}
