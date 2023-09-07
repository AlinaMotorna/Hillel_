namespace days_of_sunday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int x = int.Parse(Console.ReadLine());

            if (x == 1)
            {
                Console.WriteLine("Понеділок");
            }
            else if (x == 2)
            {
                Console.WriteLine("Вівторок");
            }
            else if (x == 3)
            {
                Console.WriteLine("Середа");
            }
            else if (x == 4)
            {
                Console.WriteLine("Четверг");
            }
            else if (x == 5)
            {
                Console.WriteLine("П'ятниця");
            }
            else if (x == 6)
            {
                Console.WriteLine("Суббота");
            }
            else if (x == 7)
            {
                Console.WriteLine("Неділя");
            }
            else
            {
                Console.WriteLine("Не день тижня!");
            }
            Console.ReadKey();
        }
    }
}