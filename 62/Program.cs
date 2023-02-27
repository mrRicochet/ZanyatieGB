// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int GetNumbers(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] SpiralFillMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    int c = 1;
    int k = 0;
    int l = 0;

    for (int i = 0; i < rows - k; i++)
    {
        for (int j = l; j < cols - l; j++)
        {
            matrix[i, j] = c;
            c++;
        }
        for (int m = i + 1; m < rows - k; m++)
        {
            matrix[m, cols - 1 - l] = c;
            c++;
        }
        for (int n = cols - 2 - l; n >= l; n--)
        {
            matrix[rows - 1 - k, n] = c;
            c++;
        }
        for (int r = rows - 2 - k; r > k; r--)
        {
            matrix[r, l] = c;
            c++;
        }
        k++;
        l++;
    }
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

int rows = GetNumbers("Введите количество строк матрицы: ");
int cols = GetNumbers("Введите количество столбцов матрицы: ");

int[,] myMatrix = SpiralFillMatrix(rows, cols);

PrintMatrix(myMatrix);
System.Console.WriteLine();