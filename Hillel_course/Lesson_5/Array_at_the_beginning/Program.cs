namespace Array_at_the_beginning
{
    class Program
    {
        static void Main(string[] args)
        {
            //До масиву додається елемент на початок.
            int[] nums = { -100, 2, 3, 4, 5, 6, 70, 8, 9, 10 };
            int a = 1000;
            int[] largerArray = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                largerArray[i] = nums[i];
            }
            largerArray[largerArray.Length - 1] = a;

            foreach (var elem in largerArray)
            {
                Console.WriteLine(elem);
            }
        }
    }
}

