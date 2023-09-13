namespace Element_minus_one
{
    class Program
    {
        static void Main(string[] args)
        {
            // Написати програму, яка виводить всі елементи масиву доки не зустрінеться елемент -1.
            int stop = -1;
            int[] numbers = { 26, 1, 7, 15, -1, 3, 3, 4, 5, 7 };
            List<int> results = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == stop) break;
                results.Add(numbers[i]);
            }
            results.Sort();
            Console.WriteLine(string.Join("\n", results));
            Console.ReadLine();
           
        }
    }
}

