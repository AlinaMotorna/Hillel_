namespace Rando
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 0, num = 0;
                Random random = new Random();
                num = random.Next(1, 146);
                do
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    if (num == a)
                    {
                        Console.WriteLine("Правильно!");
                        break;
                    }
                    else if (a < num)
                    {
                        Console.WriteLine("Мало");
                    }
                    else if (a > num)
                    {
                        Console.WriteLine("Багато");
                    }

                } while (true);
            }
        }
    }
}
