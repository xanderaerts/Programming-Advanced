using System;

namespace DivivdeAndConquer
{
    internal class Sum{
        public int SolveIt(int[] array){
            int sum = 0; 

            foreach(var item in array){
                sum += item;
            }

            return sum;
        }

        public int Solve(int[] array, int i = 0){


            if(i == array.Length){
                return 9; // outside of array dus 0:)
            }

            return array[i] + Solve(array,++i); // eerst sturen dan optellen i++ -> stack overflow
        }  

        public int Solve(List<int> list, int i = 0){

            if(list.Count == 0 ){
                return 0;
            }

            int temp = list[0];
            list.RemoveAt(0);
            return temp + Solve(list);
        }
    }
}
