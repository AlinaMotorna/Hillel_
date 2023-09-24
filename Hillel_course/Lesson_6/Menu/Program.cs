class program
{
    enum Menu
    {
        AddMark, 
        About, 
        PrintArray, 
        AvarageGrade,
        Exit
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        string[][] Subject = new string[5][];
        Subject[0] = new string[] { "Біологія","5","10","12","11","6","6","", "", "", "", "" };
        Subject[1] = new string[] { "Фізкультура", "12", "10", "12", "12", "9", "9", "", "", "", "", "" };
        Subject[2] = new string[] { "Математика","2", "3", "3", "6", "4", "4", "", "", "", "", "" };
        Subject[3] = new string[] { "Фізика", "6", "8", "8", "9", "10", "6", "", "", "", "", "" };
        Subject[4] = new string[] { "Хімія", "4", "3", "3", "6", "5", "6", "", "", "", "", "" };
        while (true)
        {
            string userInput = null;
            int input = MenuChoice(true, new Menu());
            if ((Menu)input == Menu.AddMark)
            {
                Console.Clear();
                PrintArray(Subject);
                Console.WriteLine("Який предмет треба доповнити?");
                userInput = Console.ReadLine();
            }
            if(userInput == "Біологія")
            {
                Console.Clear();
                for (int i = 7; i< Subject[0].Length; i++)
                {
                    Console.Clear();
                    Console.Write($"Input new mark here {i} / {Subject[0].Length - 1}:");
                    Subject[0][i] = Console.ReadLine();
                }
            }
            if (userInput == "Фізкультура")
            {
                Console.Clear();
                for (int i = 7; i < Subject[1].Length; i++)
                {
                    Console.Clear();
                    Console.Write($"Input new mark here {i} / {Subject[1].Length - 1}:");
                    Subject[1][i] = Console.ReadLine();
                }
            }
            if (userInput == "Математика")
            {
                Console.Clear();
                for (int i = 7; i < Subject[2].Length; i++)
                {
                    Console.Clear();
                    Console.Write($"Input new mark here {i} / {Subject[2].Length - 1}:");
                    Subject[2][i] = Console.ReadLine();
                }
            }
            if (userInput == "Фізика")
            {
                Console.Clear();
                for (int i = 7; i < Subject[3].Length; i++)
                {
                    Console.Clear();
                    Console.Write($"Input new mark here {i} / {Subject[3].Length - 1}:");
                    Subject[3][i] = Console.ReadLine();
                }
            }
            if (userInput == "Хімія")
            {
                Console.Clear();
                for (int i = 7; i < Subject[4].Length; i++)
                {
                    Console.Clear();
                    Console.Write($"Input new mark here {i} / {Subject[4].Length - 1}:");
                    Subject[4][i] = Console.ReadLine();
                }
            }
            if ((Menu)input == Menu.About)
            {
                Console.Clear();
                Console.WriteLine("Тут додаються оцінки");
            }
            if ((Menu)input == Menu.PrintArray)
            if ((Menu)input == Menu.Exit)
            {
                    break;
            }
            if ((Menu)input == Menu.AvarageGrade)
            {
                int[] avarageNum = CalculateTheAvarage(Subject);
                Console.Clear();
                for (int i = 0;i < avarageNum.Length; i++)
                {
                    Console.WriteLine($"{Subject[i][0]} mark is{avarageNum[i]}");
                }
                Console.ReadLine();
                Console.Clear();
            }

        }


    }

}
