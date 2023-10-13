using System;

namespace extraOef
{
    public class ReverseString
    {
        public string Iterative(string n){
            return "doet niks";
        }

        public string Recursive(string word){
            if(word.Length == 1) return word;

            return word[word.Length - 1] + Recursive(word.Remove(word.Length -1));
            
        }
    }
}
