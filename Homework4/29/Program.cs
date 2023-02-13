// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arrN = new int[size]; // создает какой-то массив на size элементов
    for (int i = 0; i < size; i++)         //
    {                                      // рандомно заполняет массив
        arrN[i] = new Random().Next(leftRange, rightRange); //
    }
    return arrN; // возвращает массив
}

void PrintArray(int[] array) // получает на вход массив
{
    System.Console.WriteLine("["+string.Join(", ", array)+"]");
}
int sizeCol = GetNumber("Введите количество чисел в массиве: ");
int left = GetNumber("Введите нижний порог в массиве: ");
int right = GetNumber("Введите верхний порог в массиве: ");

int[] array1 = GetArray(sizeCol, left, right);
PrintArray(array1);