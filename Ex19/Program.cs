while (true)
{
    int userNumber = GetUserNumber("Введите пятизначное число: ");

    int firstNumber = GetNumberByIndex(userNumber, 1);
    int lastNumber = GetNumberByIndex(userNumber, 5);
    int secondNumber = GetNumberByIndex(userNumber, 2);
    int fourthNumber = GetNumberByIndex(userNumber, 4);
    if (userNumber >= 10000 && userNumber < 100000)
    {
        if (firstNumber == lastNumber && secondNumber == fourthNumber)
            Console.WriteLine($"{userNumber} является палиндромом");
        else
            Console.WriteLine($"{userNumber} не является палиндромом");
        break;
    }
    else
        Console.WriteLine($"ОШИБКА! {userNumber} НЕ ЯВЛЯЕТСЯ ПЯТИЗНАЧНЫМ");
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
static int GetNumberByIndex(int number, int index)
{
    int digit;
    if (index == 1)
    {
        digit = number / 10000;
        return digit;
    }
    else
    {
        if (number >= Math.Pow(10, index - 1))
            while (number >= Math.Pow(10, index))
            {
                number /= 10;
            }
        digit = number % 10;
        return digit;
    }
}
