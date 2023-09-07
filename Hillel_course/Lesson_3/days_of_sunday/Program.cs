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
            if (x == 2)
            {
                Console.WriteLine("Вівторок");
            }
            if (x == 3)
            {
                Console.WriteLine("Середа");
            }
            if (x == 4)
            {
                Console.WriteLine("Четверг");
            }
            if (x == 5)
            {
                Console.WriteLine("П'ятниця");
            }
            if (x == 6)
            {
                Console.WriteLine("Суббота");
            }
            if (x == 7)
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