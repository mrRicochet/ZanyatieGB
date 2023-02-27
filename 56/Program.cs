// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

int GetNumbers(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            matrix[i, j] = rand.Next(-10, 11);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            System.Console.Write(matrix[i, j] + "\t");
        System.Console.WriteLine();
    }
}

void MinSumRow(int[,] matrix, out int minI, out int minSum)
{
    minSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        minSum += matrix[0, j];
    minI = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            sum += matrix[i, j];
        if (sum < minSum)
        {
            minSum = sum;
            minI = i;
        }
    }
}

int rows = GetNumbers("Введите количество строк матрицы: ");
int cols = GetNumbers("Введите количество столбцов матрицы: ");

int[,] myMatrix = GenerateMatrix(rows, cols);

PrintMatrix(myMatrix);
System.Console.WriteLine();
MinSumRow(myMatrix, out int minI, out int minSum);
System.Console.WriteLine($"Наименьшая сумма элементов {minSum} в {minI + 1} строке");
System.Console.WriteLine();