// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int[] InputArray(string text)
{
    System.Console.WriteLine(text);
    var array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
    return array;
}

int CountPositive(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            result++;
    }
    return result;
}

int[] MyArray = InputArray("Введите числа через запятую: ");
System.Console.WriteLine($"Среди введенных чисел {CountPositive(MyArray)} положительных.");