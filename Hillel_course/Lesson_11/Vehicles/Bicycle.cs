using System.Xml.Linq;

namespace Vehicles
{
    internal class Bicycle : Transport
    {
        string type_bicycle;

        public Bicycle()
        {
        }

        public Bicycle(string name, string max_speed, string type_bicycle) : base()
        {
            name = "Merida";
            max_speed = "50";
            type_bicycle = "BMX";
        }
        public void Transport()
        {
            Console.WriteLine($"name ={name}");
            Console.WriteLine($"max speed ={max_speed}");
            Console.WriteLine($"type bicycle  ={type_bicycle}");
        }
    }
}
