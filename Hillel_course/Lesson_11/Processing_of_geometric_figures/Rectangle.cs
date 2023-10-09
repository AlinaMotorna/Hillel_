namespace Processing_of_geometric_figures
{
    class Rectangle : Figure
    {
       public int width;
       public int height;

        public Rectangle() : base()
        {
            this.width = 25;
            this.height = 43;
            x = 25;
            y = 32;
        }
        public void determines()
        {
            Console.WriteLine($"Rectangle:");
            Console.WriteLine($"width ={width}");
            Console.WriteLine($"height ={height}");
            Console.WriteLine($"x ={x}");
            Console.WriteLine($"y ={y}");
        }
    }
       
}
