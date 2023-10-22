namespace Sorting_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 8, 12, 15, 18, 22 };
            var evens1 = numbers.Where(i => i % 2 == 0 && i > 10);
        }
    }
}
