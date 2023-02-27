// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplayMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] resMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for (int i = 0; i < matrixA.GetLength(0); i++)
            for (int k = 0; k < matrixB.GetLength(1); k++)
            {
                int sum = 0;
                for (int j = 0; j < matrixA.GetLength(1); j++)
                    sum += matrixA[i, j] * matrixB[j, k];
                resMatrix[i, k] = sum;
            }
    }
    else System.Console.WriteLine("Ошибка! Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы!");
    return resMatrix;
}

int rowsA = GetNumbers("Введите количество строк первой матрицы: ");
int colsA = GetNumbers("Введите количество столбцов первой матрицы: ");
int rowsB = GetNumbers("Введите количество строк второй матрицы: ");
int colsB = GetNumbers("Введите количество столбцов второй матрицы: ");

int[,] myMatrixA = GenerateMatrix(rowsA, colsA);
int[,] myMatrixB = GenerateMatrix(rowsB, colsB);

PrintMatrix(myMatrixA);
System.Console.WriteLine();

PrintMatrix(myMatrixB);
System.Console.WriteLine();

int[,] multiplyMatrix = MultiplayMatrix(myMatrixA, myMatrixB);
PrintMatrix(multiplyMatrix);
System.Console.WriteLine();