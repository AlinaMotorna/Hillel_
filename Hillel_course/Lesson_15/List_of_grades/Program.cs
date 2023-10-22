namespace List_of_grades
{
    class Program
    {
        
            static void Main(string[] args)
            {
                int[] arr = new int[] { 85, 92, 78, 95, 88, 90 };

            var lst = from a in arr where a > 89 select a;
            int[] arr2 = lst.ToArray();

            for (int i = 0; i < arr2.Length; i++)
                Console.Write($"{arr2[i]}\t");
            Console.ReadKey();
            }
        
    }
}

