
namespace HashTables
{
    internal class Book_KVP
    {
        private KeyValuePair<string,double>[] Book;
        int index;

        public Book_KVP(int i)
        {
            this.index = 0;

            this.Book = new KeyValuePair<string, double>[i];
        }

        internal void AddItem(string name, double price)
        {
            this.Book[this.index] = new KeyValuePair<string, double>(name,price);
            index++;
        }

        internal string GetPrice(string v)
        {
            foreach(var vr in this.Book){
                if(vr.Key == v){
                    return vr.Value.ToString();
                }
            }

            return "Item does not exists";
        }

        public override string ToString()
        {
            string output = "";
            foreach(var vr in this.Book){
                if(vr.Key != null){
                    output += $"Product name: {vr.Key} -> price: {vr.Value}\n";
                }
            }

            return output;
        }
    }
}