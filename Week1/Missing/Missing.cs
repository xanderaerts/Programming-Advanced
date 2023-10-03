using System;

namespace Missing
{
    public class Missing
    { 
        public double findMissing(List<int> input){
            double missing = -1,sum = 0,expected = 0;

            for (int i = 0; i < input.Count; i++) {
                sum += input[i];
            }

            expected = ((double)(input.Count + 1) / 2) * (input[0] + input[input.Count - 1]);

            missing = expected - sum;

           

            return missing;
        }
    }
}
