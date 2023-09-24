namespace Working_with_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address()
            { Index = 6678, Country = "Ukraine",City = "Cherkassy",Street= "Gogol Street",House = "House No 2", Apartment = "Apartment-B" };
            address.PrintAddress();
            Console.ReadKey();  
        }
    }
}
