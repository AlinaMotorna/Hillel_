namespace Working_with_class_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                Console.Write("Довжина: ");
                int side1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ширина: ");
                int side2 = Convert.ToInt32(Console.ReadLine());

                int area = side1 * side2;

                Console.WriteLine("Площа прямокутника: {0}", area);
                Console.ReadLine();
                Console.ReadKey();
            }
        }
    }
}