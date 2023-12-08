using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Xml;

namespace HashTables
{
    public class Book_HashSep
    {
        private List<KeyValuePair<string,double>>[] book;
        
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
            return number - 1;
        }

        private bool checkPrimeNumber(int  nr){

            for(int i = 2; i < nr/2; i++){
                if(nr % i == 0 ) return false;
            }
            return true;
        }

        public Book_HashSep(int keys){
            book = new List<KeyValuePair<string, double>>[NextPrime(keys * 1.3)];
        }

        private int HashFuntion(string key){
            long index = 0;            
            foreach( char c in key) index = (31*index) + (int)c;

            return (int)(index % book.Length);
        }

        public void AddItem(string product, double price){
            int index = HashFuntion(product);

            if(book[index] == null){
                book[index] = new List<KeyValuePair<string, double>>();
            }
            
            book[index].Add(new KeyValuePair<string, double>(product,price));
        }

        public double GetPrice(string product){
            int index = HashFuntion(product);


            foreach(var item in this.book[index]){
                if(item.Key == product) return item.Value;
            }

            return 0;
        }

        public override string ToString()
        {
            string output = "";

            for(int i = 0; i < this.book.Length; i++){

                output += i+" ";

                if(book[i] != null){
                    foreach(var item in this.book[i]){
                        output += item.Key + ":" + item.Value + " -->" +"\n";
                    }
                }
                else output += "null" + "\n";
            }

            return output;
        }
    }
}