// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumAllNum(int number)
{
    int res = 0;
    while(number > 0)
    {
        res += number % 10;
        number = number / 10;
    }
    return res;
}

int num = GetNumber("Введите число: ");
System.Console.WriteLine($"Сумма всех цифр в числе {num} = {SumAllNum(num)}");