namespace Search_for_maximum_index
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] cost = { 10, 25, 8, 45, 15, 30, 55, 5 };

            int max = -1;
            int index = -1;
            
            for (int i = 0; i < cost.Length; i++)
                if (max <= cost[i])
                {
                    max = cost[i];
                    index = i;
                }
            Console.WriteLine(index);
            Console.ReadKey();
        }

    }
}

