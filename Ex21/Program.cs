int x1 = GetUserNumber("Введите значение x1: ");
int y1 = GetUserNumber("Введите значение y1: ");
int z1 = GetUserNumber("Введите значение z1: ");
int x2 = GetUserNumber("Введите значение x2: ");
int y2 = GetUserNumber("Введите значение y2: ");
int z2 = GetUserNumber("Введите значение z2: ");


double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {result:f2}");


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