using System;
using System.Runtime.InteropServices;

namespace Wally
{
    public class Sorting
    {
        public int counter; 

        public string[] CycleSort(string[] input){
            int start = 0;
            this.counter = 0;

            for(int i = 0; i <= input.Length -2; i++){
                string item = input[i];

                int pos = i;

                for(int j = i + 1; j < input.Length; j++){
                    if(input[j].CompareTo(item) < 0){
                        pos++;
                    }
                }

                if(pos == i){continue;}

                while(item == input[pos]){
                    pos += 1;
                }

                if(pos != i){
                    string temp = item;
                    item = input[pos];
                    input[pos] = temp;
                    counter++;
                }


               while(pos != i){


                    pos = i;

                    for(int j = i + 1;j < input.Length; j++ ){
                        if(input[j].CompareTo(item) < 0){
                            pos += 1;
                        }
                    }

                   while(item.CompareTo(input[pos]) == 0){
                        pos += 1;
                    }

                    if(item.CompareTo(input[pos]) != 0){
                        string temp = item;
                        item = input[pos];
                        input[pos] = temp;
                        counter++;
                    }
                } 

            }
            return input;

        }

        public string[] ShellSort(string[] input){

            this.counter = 0;
            
            for(int gap = input.Length/2; gap > 0; gap /= 2){

                for(int i = gap; i < input.Length; i++){

                    string temp = input[i];

                    int j;

                    for(j = i; j >= gap && input[j - gap].CompareTo(temp) > 0; j -= gap){
                        input[j] = input[j-gap];
                        counter++;
                    }

                    input[j] = temp;
                    counter++;
                }
            }
            return input;
        }
    }
}
