namespace Alphabetical_order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string[] fruct = { "Яблуко", "Апельсин", "Банан", "Ківі" };
            var orderedfruct = from f in fruct orderby f select f;
            foreach (var f in orderedfruct)
                Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
