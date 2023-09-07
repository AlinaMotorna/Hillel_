namespace month_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("Зима");
            }
            if (x == 2)
            {
                Console.WriteLine("Зима");
            }
            if (x == 12)
            {
                Console.WriteLine("Зима");
            }
            if (x == 3)
            {
                Console.WriteLine("Весна");
            }
            if (x == 4)
            {
                Console.WriteLine("Весна");
            }
            if (x == 5)
            {
                Console.WriteLine("Весна");
            }
            if (x == 6)
            {
                Console.WriteLine("Літо");
            }
            if (x == 7)
            {
                Console.WriteLine("Літо");
            }
            if (x == 8)
            {
                Console.WriteLine("Літо");
            }
            if (x == 9)
            {
                Console.WriteLine("Осінь");
            }
            if (x == 10)
            {
                Console.WriteLine("Осінь");
            }
            if (x == 11)
            {
                Console.WriteLine("Осінь");
            }
            else 
            {
                Console.WriteLine("Немоє такого місяця");
             }
            Console.ReadKey();
        }
    }
}
