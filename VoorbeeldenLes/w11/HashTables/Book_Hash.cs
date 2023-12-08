using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace HashTables
{
    public class Book_Hash
    {
        private double[] book;
        
        private int NextPrime(double nr){
            int number = (int)nr;

            if(checkPrimeNumber(number)){

                return number;
            }
            else{
                while(!checkPrimeNumber(number)){
                    number+=1;
                }                
            }
            return number;
        }

        private bool checkPrimeNumber(int  nr){

            for(int i = 2; i < nr/2; i++){
                if(nr % i == 0 ) return false;
            }
            return true;
        }

        public Book_Hash(int keys){
            book = new double[NextPrime(keys*1.3)];
        }

        private int HashFuntion(string key){
            int index = 0;

            /*foreach (char c in key)
            {
                index += c;
            }*/

        /*
            for(int i = 0; i < key.Length;i++){
                index += (int)key[i] * (int)Math.Pow(31,i);
            }
        */
            
            foreach( char c in key) index = (31*index) + (int)c;

            return (int)index % book.Length;
        }

        public void AddItem(string product, double price){
            int index = HashFuntion(product);
            book[index] = price; 
        }

        public double GetPrice(string product){
            return this.book[HashFuntion(product)];
        }

        public override string ToString()
        {
            return string.Join(" ",this.book) + "\n";
        }
    }
}
