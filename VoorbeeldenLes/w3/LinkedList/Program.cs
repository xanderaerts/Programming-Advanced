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

            Console.WriteLine($"{list.Search("peer")}");
            Console.WriteLine($"{list.Search("appel")}");
            Console.WriteLine($"{list.Search("iets")}");

            
            list.Remove("peer");
            Console.WriteLine(list);
            list.Remove("appel");
            Console.WriteLine(list);
            list.Remove("banaan");
            Console.WriteLine(list);
            list.Remove("druif");
            Console.WriteLine(list);

        }
    }
}