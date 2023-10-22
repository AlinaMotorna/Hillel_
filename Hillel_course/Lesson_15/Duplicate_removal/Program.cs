public class Example
{
    public static List<T> removeDuplicates<T>(List<T> list)
    {
        return new HashSet<T>(list).ToList();
    }

    public static void Main()
    {
        List<string> list = new List<string> { "А", "Б", "В", "А", "Г", "В" };
        List<string> distinct = removeDuplicates(list);

        Console.WriteLine(String.Join(",", distinct));
        Console.ReadKey();
    }
}

