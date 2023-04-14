int userNumber = GetUserNumber("Введите пятизначное число: ");

int firstNumber = GetNumberByIndex(userNumber, 1);
int lastNumber = GetNumberByIndex(userNumber, 5);
int secondNumber = GetNumberByIndex(userNumber, 2);
int fourthNumber = GetNumberByIndex(userNumber, 4);
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
        else
            Console.Write($"В числе {number} нет {index}-го значения");
        digit = number % 10;
        return digit;
    }
}
