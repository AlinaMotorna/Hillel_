namespace Array_at_the_beginning
{
    class Program
    {
        static void Main(string[] args)
        {
            //До масиву додається елемент на початок.
            int[] nums = { 0, 3, 6, 8, 6, 7, 99, 50, 61, 10 };
            int a = 10;
            int[] largerArray = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                largerArray[i] = nums[i];
            }
            largerArray[largerArray.Length - 11] = a;

            foreach (var elem in largerArray)
                
            {
                Console.WriteLine(elem);
            }
        }
    }
}

