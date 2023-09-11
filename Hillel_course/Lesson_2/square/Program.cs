namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть число:");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine($"{sum * sum}");
            Console.ReadKey();
        }
    }
}