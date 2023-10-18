using System.Drawing;

namespace Movable
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Car car = new Car();
            Point position = new Point(140,50);
            

            Console.ReadKey();
        }
    }
}

