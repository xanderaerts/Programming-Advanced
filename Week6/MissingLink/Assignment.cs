using System;
using System.Collections.Generic;
using System.Linq;

namespace Module_06 
{
    public class Assignment
    {
        public string Missing(List<int> input){
            List<int> sorted = Sort(input);

            int current = 0, next = 0;

            for(int i = 0; i < sorted.Count-1; i++){
                if(sorted[i + 1] - sorted[i] > 1 ){
                    if(sorted[i] + 1 > 0) return (sorted[i] + 1).ToString();
                }
            }

            return "No missing link";
        
        }

        public List<int> Sort(List<int> list){
            if(list.Count <= 1) return list;

            int pivot = list[0];

            List<int> lower = new List<int>();
            List<int> higher = new List<int>();

            foreach(var item in list){
                if(item < pivot) lower.Add(item);
                else if(item > pivot) higher.Add(item);
            }

            return Sort(lower).Union(new List<int> {pivot}).Union(Sort(higher)).ToList();
        }
    }
}