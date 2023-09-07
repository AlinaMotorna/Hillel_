namespace paired_unpired
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.(Console.ReadLine());
            if ((x % 2) == 0) 
            {
                Console.WriteLine("парне");
                    }
            else
            {
                Console.WriteLine("не парне");
                    }
            Console.ReadKey();
        }
    }
}