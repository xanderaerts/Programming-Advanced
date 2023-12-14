using System.Collections.Generic;
using System;
using System.Linq;
namespace Module_05
{
    public class Assignment
    {

        public List<string> anwser = new List<string>();

        public void SearchWords(List<string> words,string inputString){
            List<string> results = new List<string>();

            foreach(string input in inputString.Split(" ")){

                int amountOptions = (int)Math.Pow(2,input.Length-1);

                for(int i = amountOptions; i >= 0; i--){

                    string ibin = Convert.ToString(i,2).PadLeft(input.Length-1,'0');

                    string newString = input;
                    int spacesAdded = 0;

                    for(int j = 0; j < input.Length-1; j++){

                        if(ibin[j] == '1'){
                            newString = newString.Insert(j+1 + spacesAdded," ");
                            spacesAdded++;
                        }
                    }

                    foreach(string word in newString.Split(" ")){
                        if(!results.Contains(word)) {
                            results.Add(word);
                            if(words.Contains(word)) this.anwser.Add(word);
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            string output = "";
            foreach(string w in this.anwser){
                output +=  w + " ";
            }
            if(output.Length > 0) return output.Remove(output.Length-1);
            else return null;
        }
    }
}
