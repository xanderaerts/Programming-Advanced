using System;

namespace Wally
{
    public class Search
    {
        public int SearchWally(string[] input){

            string Wally = "Wally";

            int low = 0, high = input.Length - 1;

            while(low <= high){
                int mid = (low + high) / 2;

                if(input[mid].CompareTo(Wally) == 0){
                    return mid;
                }
                else if(Wally.CompareTo(input[mid]) < 0){
                    high = mid - 1;
                }
                else{
                    low = mid + 1;
                }
            }

            return -1;
        }
    }
}
