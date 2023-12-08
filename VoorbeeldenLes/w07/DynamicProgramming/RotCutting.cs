using System;
using System.Text.Json.Serialization;

namespace DynamicProgramming
{
    public class RotCutting
    {
        //R_n​=max(p_i​+r_n−i​) with 1<=i<=n


        public int[] prices {get;set;}

        public RotCutting(int[] prices){
            this.prices = prices;
        }

        public int Recursion(int n){
            Console.WriteLine("calls" + n + " ");


            if(n < 0) throw new Exception("");

            if(n ==  0)return prices[0];

            int r = 0; 
            for(int i = 1; i <= n;i++){
                r = Math.Max(r,prices[i] + Recursion(n-i));
            }

            return r;
        }

        public int Memoization(int n,int[] array){
            Console.WriteLine("calls" + n + " ");


            if(n < 0) throw new Exception("");

            if(n ==  0)return prices[0];

            if(array[n] != 0) return array[n];


            for(int i = 1; i <= n;i++){
                array[n] = Math.Max(array[n],prices[i] + Memoization(n-i, array));
            }

            return array[n];
        }


        public int Tabulation(int n){
        Console.WriteLine("calls" + n + " ");


        if(n < 0) throw new Exception("");

        if(n ==  0)return prices[0];

        int[] array = new int[n + 1];


        for(int i = 1; i <= n;i++){

            for(int j = 1; j<= i;j++){
                array[i] = Math.Max(array[i],prices[j] + array[i - j]);
            }
        }

        return array[n];
        }



    }
}
