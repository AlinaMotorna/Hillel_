namespace DocumentWorker
{
    internal class Documentworker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ відкрито");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документа доступне у версії Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа доступне у версії Про");
        }
    }
}
