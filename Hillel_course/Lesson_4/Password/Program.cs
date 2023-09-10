namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string password = "root", input = string.Empty;
            while (input != password) 
            {
                Console.WriteLine("Введіть пароль:");
                input = Console.ReadLine();
                Console.WriteLine("Пароль не вірний!\n");
            }
            Console.WriteLine("Пароль вірний!");
            Console.ReadKey();
        }
    }
}
