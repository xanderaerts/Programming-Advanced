using System;

namespace Module_01
{
    public class Assignment
    { 
        public string Missing(int[] array){
            /* double missing = -1,sum = 0,expected = 0;

             for (int i = 0; i < array.Length; i++) {
                 sum += array[i];
             }

             expected = ((double)(array.Length + 1) / 2) * (array[0] + array[array.Length - 1]);

             Console.WriteLine(expected);
             Console.WriteLine(sum);

             missing = expected - sum;

             if (missing == 0)
             {
                 return "No missing number.";
             }
             else
             { return missing.ToString(); } */

            int missing = -1, one, two;

            for (int i = 0; i < array.Length - 1; i++)
            {
                one = array[i];
                two = array[i + 1];

                if ((two - one) > 1)
                {
                    missing = one + 1;
                    break;
                }
            }

            if (missing == -1) { return "No missing number."; }
            else { return missing.ToString(); }


        }
    }
}
