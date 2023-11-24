using System;

namespace Module_07 
{
    public class Assignment
    {
        public string PrintAlphabet(int input){

            if(input < 0 ) throw new Exception();

            if(input > 26) throw new Exception();

            string output = "";

            int ascii = 97;

            if(input == 0) return "";

            string binary = Convert.ToString(input,2);

            foreach(char c in binary){
                if(c == '1'){
                    output += Convert.ToChar(ascii);
                }

                ascii++;
            }

            return PrintAlphabet(input - 1) + " " + output;
        }
    }
}
