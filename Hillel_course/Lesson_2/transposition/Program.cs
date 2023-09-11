 namespace transposition
{
    class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Введіть число:");
        int sum = int.Parse(Console.ReadLine());
        int sum1 = sum / 100;
        int sum2 = (sum - (sum1 * 100)) / 10;
        int sum3 = sum % 10;
        Console.WriteLine($"{(sum2 * 100) + (sum1 * 10) + sum3}");
        Console.ReadKey();
    }
}
}
