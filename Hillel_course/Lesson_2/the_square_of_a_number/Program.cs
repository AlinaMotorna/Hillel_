namespace the_square_of_a_number
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sum: ");
            int inputNum = int.Parse(Console.ReadLine());

            int firstDigit = inputNum;
            int secondDigit = inputNum;

            Console.WriteLine($"{firstDigit * secondDigit}");
            Console.ReadKey();
        }
    }
}
