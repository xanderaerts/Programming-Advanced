using System;

namespace Module_01 
{
    public class Assignment
    {
        public string NthCharacter(int number, string filename){

            string[] rawInput = File.ReadAllLines(filename);

            int rowNumber = number / 10; 
            int place = (number % 10);

            string word = rawInput[rowNumber];
            string letter = word[place].ToString();

            return letter;

        


        }
        
    }
}
