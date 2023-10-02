using System;

namespace Missing
{
    public class Missing
    { 
        public int findMissing(List<int> input){

            int missing=-1,one, two;

            for (int i = 0; i < input.Count-1; i++) {
                one = input[i];
                two = input[i+1];

                if ((two - one) > 1) {
                    missing = one + 1;
                    break;
                }
            }

            return missing;
        }
    }
}
