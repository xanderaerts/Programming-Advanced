using System;

namespace extraOef
{
    public class CountDigits
    {
        public int Iterative(int n){

            int count = 1;
            
            for(int i = 10; i <= n ; i *= 10){
                if(n < i){
                    return count;
                }
                count++;

            }
            return count;
        }

        public int Recursive(int n){
            if(n < 10){return 1;}

            return 1 + Recursive(n / 10);
        }

        //print array
        public void For(int i, int[] array){
            Console.WriteLine(array[i]);

            if(i == array.Length - 1){return;}
            
            For(i + 1, array);
        }

        //print alle getallne tot n
        public string For2(int i, int start){
            if(start == i)return i.ToString();

            return start + " " + For2(i, start + 1);

        }
    }
}
