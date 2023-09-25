namespace W1
{
    internal class Program {
        static void Main(string[] args) {

            string[] array = File.ReadAllLines("words.txt");

            Duplicates dp = new Duplicates();


            Console.WriteLine("Give 2 characters: ");

            string inputStr = Console.ReadLine();

            List<string> doubles = dp.findDubble(array, inputStr);


            for (int i = 0; i < doubles.Count; i++) {
                Console.WriteLine($"{doubles[i]}");
            }


        }
    }
}