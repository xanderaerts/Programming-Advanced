using System;

namespace extraOef
{
    public class Sum
    {
        public int Iterative(int n){
            int sum = 0; 

            for(int i = 0; i <= n; i++){
                sum += i;
            }

            return sum;
        }

        public int Recursive(int n){

            if(n == 0){
                return 0;
            }

            return n + Recursive(n - 1);
        }
    }
}
