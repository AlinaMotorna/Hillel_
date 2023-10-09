namespace Processing_of_geometric_figures
{
    class Circle : Figure
    {
        public int radius;

        public Circle() : base()
        {
            radius = 12;
            x = 20;
            y = 30;
        }
        public void determines()
        {
            Console.WriteLine($"circle radius ={radius}");
            Console.WriteLine($"x ={x}");
            Console.WriteLine($"y ={y}");
        }
    }
}
