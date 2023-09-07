namespace comparsion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Enter sum a: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter sum b: ");
            
            int z = int.Parse(Console.ReadLine());
            if (x > z)
            {
                Console.WriteLine("a > b");
            }
            if (x < z)
            {
                Console.WriteLine("a < b");
            }
            else
            {
                Console.WriteLine("a = b");
            }
                Console.ReadKey();
        }
    }
}
