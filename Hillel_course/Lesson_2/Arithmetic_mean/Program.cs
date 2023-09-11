namespace Arithmetic_mean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть число:");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число:");
            int sum1 = int.Parse(Console.ReadLine());
            Console.Writeline($"Середнє арифметичне: {(sum + sum1) / 2}");
            Console.ReadKey();
        }
    }
}
