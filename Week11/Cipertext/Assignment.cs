using System;
using System.IO;
using System.Linq;

namespace Module_11 
{
    public class Assignment
    {
        public void Decrypt(string input){

            string[] words = File.ReadAllLines("english.txt");

            for(int i = 1; i <= 26; i++){
                string decryptedWord = Resolve(input,i);

                if(words.Contains(decryptedWord.ToLower())){
                    Console.WriteLine($"Shift {i} - {decryptedWord}");
                    return;
                }
            }

            throw new Exception();
        }

        private string Resolve(string input, int shift ){
            char[] chars = new char[input.Length];

            for(int i = 0; i < input.Length; i++){

                char curChar = input[i];

                char baseChar = char.IsUpper(curChar) ? 'A' : 'a';

                chars[i] = (char)((curChar - -baseChar - shift + 26) % 26 + baseChar);
            }

            return new string(chars);
        }
    }
}
