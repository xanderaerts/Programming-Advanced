using System;
using System.Security;

namespace BackTracking
{
    public class Subset
    {
        public List<List<int>> Solve(int[] ints){
            List<List<int>> results = new List<List<int>>();
            List<int> list = new List<int>();

            CreateSubset(ints,0,results,list);

            return results;
       } 

       private void CreateSubset(int [] array, int index, List<List<int>> results,List<int> subset){
            results.Add(new List<int>(subset)); //nieuwe lijst anders add referentie

            for(int i = index; i < array.Length;i++){
                subset.Add(array[i]);
                CreateSubset(array,i + 1, results,subset);
                subset.RemoveAt(subset.Count-1);
            }
       }



        public List<List<int>> SolveBinary(int[] ints){

            List<List<int>> results = new List<List<int>>();

            int count = (int)Math.Pow(2, ints.Length);

            for(int i = 0; i < count; i++){
                List<int> list = new List<int>();
                string binary = Convert.ToString(i, 2).PadLeft(ints.Length,'0');

                for(int j = 0; j < binary.Length; j++){
                    if(binary[j] == '1') list.Add(ints[j]);
                }
                results.Add(list);
            }



            return results;
       } 


    }
}
