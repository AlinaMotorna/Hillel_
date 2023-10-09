namespace Vehicles
{
    internal class Car : Transport
    {
        int number_of_doors;

        public Car() : base()
        {
            name = "toyota";
            max_speed = "250 km/h";
            number_of_doors = 4;
            
        }
        public void Transport()
        {
            Console.WriteLine($"name ={name}");
            Console.WriteLine($"max speed ={max_speed}");
            Console.WriteLine($"number of doors ={number_of_doors}");
        }
    }

}
