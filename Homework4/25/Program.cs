// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Elevation(int numA, int numB)
{
    int res = 1;

    for (int i = 0; i < numB; i++)
    {
        res = res * numA;
    }
    return res;
}

int a = GetNumber("Введите число А: ");
int b = GetNumber("Введите число B: ");

System.Console.WriteLine($"{Elevation(a, b)}");