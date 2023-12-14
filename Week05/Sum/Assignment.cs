using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Runtime;

namespace Module_05 
{
    public class Assignment
    {       
        public void PrintCombinations(int input){

            List<List<int>> results = new List<List<int>>();
            List<int> sums = new List<int>();
       
            CreateCombinations(input,1,results,sums);
    

            foreach(List<int> list in results){
                Console.WriteLine(string.Join(" ",list));
            }
        } 

       public void CreateCombinations(int input,int index,List<List<int>> res,List<int> sums){   

            if(input == 0){
                res.Add(new List<int>(sums));
                return;
            }

            for(int i = index; i <= input; i++){
              sums.Add(i);
              CreateCombinations(input-i,i,res,sums);
              sums.RemoveAt(sums.Count-1);
            }
        }
    }
}
