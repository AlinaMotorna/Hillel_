namespace Information_about_the_user
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User()
            { Login = "Stars",Name= "Alina",Surname = "Motorna",Date = "123"};
            user.PrintUser();
            Console.ReadKey();
        }
    }
}
