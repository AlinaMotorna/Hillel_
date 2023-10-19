using Math;

namespace Information_about_the_user
{
    class Program
    {
        static void Main(string[] args)
        
        {
            try
            {
                static int Division(int x, int y) => x / 0;
            }
            catch
            {
                Console.WriteLine("Ділення на 0");
            }
            
        }
    }
}

