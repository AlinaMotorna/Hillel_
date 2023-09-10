namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            bool prost = true;
            Console.WriteLine("Введіть число\n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost)
            {
                Console.WriteLine("Число просте");
            }
            else
            {
                Console.WriteLine("Число не просте");
            }
            Console.ReadKey();
        }
    }
}