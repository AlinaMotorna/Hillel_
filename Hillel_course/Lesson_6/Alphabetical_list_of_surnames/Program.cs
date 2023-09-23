using Microsoft.VisualBasic;
using System;

namespace Alphabetical_list_of_surnames
{
    class Program
    {
        static void Main(string[] args)
        {
            // Відсортуйте введений список прізвищ за алфавітом та виведіть його на екран.
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string[] strings = { "Примушко", "Моторна", "Зміївський","Ковтун" };
            Array.Sort(strings);
            PrintArray(strings);
        }

        private static void PrintArray(string[] strings)
        {
            Console.WriteLine(string.Join("\n", strings));
            Console.ReadKey();
        }


    }
}
