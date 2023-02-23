// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rand.Next(0, 11);
    }
    return matrix;
}

void FindElement(int[,] matrix, int rowNumber, int colNumber)
{
    if (rowNumber <= matrix.GetLength(0) && colNumber <= matrix.GetLength(1))
        System.Console.WriteLine($"На {rowNumber} строке в {colNumber} столбце расположен элемент {matrix[rowNumber - 1, colNumber - 1]}");
    else
        System.Console.WriteLine("Элемента с таким номером позиции нет в массиве");
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

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");

int[,] myMatrix = GenerateMatrix(rows, cols);

int rowNumber = ReadInt("Введите номер строки матрицы: ");
int colNumber = ReadInt("Введите номер столбца матрицы: ");

System.Console.WriteLine();
FindElement(myMatrix, rowNumber, colNumber);
System.Console.WriteLine();
PrintMatrix(myMatrix);