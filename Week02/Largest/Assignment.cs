using System;
using System.Collections.Generic;

namespace Module_02
{
    public class Assignment
    {
        public string Largest(string input){


            string[] inputNumbersSplitted = input.Split(' ');
            List<int> inputNumbersInt = new List<int>();

            

            foreach(string nr in inputNumbersSplitted){
                try
                {
                    int parsed = Int32.Parse(nr);

                    if(parsed < 0) throw new Exception("Crazy Input!");

                    inputNumbersInt.Add(parsed);
                }
                catch(Exception e)
                {
                    return "Crazy input!";                 
                }
            }

            List<int> sortedList = new List<int>();
            int buffer, splitted, rest;

            for(int i = 0; i < inputNumbersInt.Count; i++){                
                int tmp = inputNumbersInt[i];
                int j;

                for(j = i; j > 0; j--){



                 //   if(inputNumbersInt[j-1]  > tmp) break; 

                    if(Compare(inputNumbersInt[j-1],tmp)) break;

                    inputNumbersInt[j] = inputNumbersInt[j-1];
                }

                inputNumbersInt[j] = tmp;

            }
            return string.Join("",inputNumbersInt);

        }

        private bool Compare(int a,int b){

            int tempA,tempB;

            if(a < 10){
                tempA = a;
            }
            else{tempA = a / 10;}
            if(b < 10){
                tempB = b;
            }else{tempB = b / 10;}

            if(tempA > tempB){
                return true;
            }
            else if(tempA == tempB){
                if(a % 10 > b % 10){
                    return true;
                }
            }


            return false;
        } 
    }

}
