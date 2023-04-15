while (true)
{
    int n = GetUserNumber("Введите значение N: ");
    double pow;

    if (n > 0)
    {

        Console.Write($"{n} -> ");
        for (int i = 1; i <= n; i++)
        {
            pow = Math.Pow(i, 3);
            Console.Write($"{pow} ");
        }
        break;
    }
    else
        Console.WriteLine("ОШИБКА! Нужно ввести значение больше нуля");
}

static int GetUserNumber(string message)
{
    while (true)
    {
        Console.Write(message);
        int userInput;
        if (int.TryParse(Console.ReadLine(), out userInput))
        {
            return userInput;
        }
        else Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕКОРРЕКТНЫЕ ДАННЫЕ");
    }
}