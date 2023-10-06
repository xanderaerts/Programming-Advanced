namespace LinkedList 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Console.WriteLine(list);

            list.Instert(new Node("appel"));
            list.Instert(new Node("druif"));
            list.Instert(new Node("banaan"));

            Console.WriteLine(list);

            list.Instert(new Node("peer"));

            Console.WriteLine(list);
        }
    }
}