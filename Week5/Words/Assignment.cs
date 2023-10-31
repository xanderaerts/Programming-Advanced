using System;

namespace Module_05
{
    public class Assignment
    {
        public List<string> SearchWords(List<string> words,string input){
            List<string> anwser = new List<string>(); 
            List<string> results = new List<string>();

            string list = "";

            CreateSubset(input, 0,results,list);

            return anwser; 
        }


        public void CreateSubset(string input,int index ,List<string> results,string subset){
            results.Add(subset);

            for(int i = index; i < input.Length; i++){
                subset += input.Substring(i,1);
                CreateSubset(input,i+1, results,subset);
                subset = subset.Remove(subset.Length-1,1);
            }

        }
    }
}
