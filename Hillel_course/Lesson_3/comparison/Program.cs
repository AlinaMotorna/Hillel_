namespace comparsion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            if (x > z)
            {
                Console.WriteLine("не рівне");
            }
            if (z > x)
            {
                Console.WriteLine("не рівне");
            }
            else
            {
                Console.WriteLine("рівне");
            }
                Console.ReadKey();
        }
    }
}
