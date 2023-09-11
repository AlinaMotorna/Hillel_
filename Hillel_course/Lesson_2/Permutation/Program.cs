namespace permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число:");
            int inputNum = int.Parse(Console.ReadLine());
            int Num1 = inputNum / 100;
            int Num2 = (inputNum - (Num1 * 100)) / 10;
            int Num3 = inputNum % 10;
            Console.WriteLine($"{(Num1) + (Num2) + (Num3)}");
            Console.ReadKey();

        }
    }
}