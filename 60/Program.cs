// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int GetNumbers(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GenerateMatrix(int size1, int size2, int size3)
{
    int[,,] matrix = new int[size1, size2, size3];
    Random rand = new Random();
    for (int i = 0; i < size1; i++)
        for (int j = 0; j < size2; j++)
            for (int k = 0; k < size3; k++)
                matrix[i, j, k] = rand.Next(10, 100);
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                System.Console.Write(matrix[i, j, k] + "(" + i + ", " + j + ", " + k + ")" + "\t");
            System.Console.WriteLine();
        }
}

int size1 = GetNumbers("Введите количество элементов первого измерения матрицы: ");
int size2 = GetNumbers("Введите количество элементов второго измерения матрицы: ");
int size3 = GetNumbers("Введите количество элементов третьего измерения матрицы: ");

int[,,] myMatrix = GenerateMatrix(size1, size2, size3);

PrintMatrix(myMatrix);
System.Console.WriteLine();