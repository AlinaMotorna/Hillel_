using System.Diagnostics.Metrics;
using System.IO;
using System.Net;

namespace Information_about_the_user
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User()
            { Login = "Stars",Name= "Alina",Surname = "Motorna",};
            user.PrintUser();
            Console.ReadKey();
        }
    }
}
