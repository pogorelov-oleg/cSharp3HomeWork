int userNumber = GetUserNumber("Введите пятизначное число: ");
int firstNumber = GetFirstNumber(userNumber);
int lastNumber = GetLastNumber(userNumber);
int secondNumber = GetSecondNumber(userNumber);
int fourthNumber = GetFourthNumber(userNumber);

if (firstNumber == lastNumber && secondNumber == fourthNumber)
    Console.Write($"{userNumber} является палиндромом");
else
    Console.Write($"{userNumber} не является палиндромом");

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
        else Console.WriteLine("Вы ввели некорректные данные ");
    }
}
static int GetFirstNumber(int number)
{
    int digit = number / 10000;
    return digit;
}
static int GetLastNumber(int number)
{
    int digit = number % 10;
    return digit;
}
static int GetSecondNumber(int number)
{
    while (number >= 100)
    {
        number /= 10;
    }
    int digit = number % 10;
    return digit;
}
static int GetFourthNumber(int number)
{
    while (number >= 10000)
    {
        number /= 10;
    }
    int digit = number % 10;
    return digit;
}

