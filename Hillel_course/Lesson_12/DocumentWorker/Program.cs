using DocumentWorker;

namespace ConsoleApplication238
{
    class Program
    {
        private const string Pro_license = "pro";
        private const string Exp_license = "exp";

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Enter license key:");
            var license = Console.ReadLine();

            
            Documentworker worker;
            switch (license)
            {
                case Pro_license: worker = new ProDocumentWorker(); break;
                case Exp_license: worker = new ExpertDocumentWorker(); break;
                default: worker = new Documentworker(); break;
            }

            
            while (true)
            {
                Console.WriteLine("Enter Command (1/2/3/4): ");
                switch (Console.ReadLine())
                {
                    case "1": worker.OpenDocument(); break;
                    case "2": worker.EditDocument(); break;
                    case "3": worker.SaveDocument(); break;
                    case "4": return;
                }
            }
        }
    }
}


