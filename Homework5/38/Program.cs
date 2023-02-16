// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным 
// элементов массива.

// [3 7 22 2 78] -> 76

double[] GenerateArray(int size) //Генерируем новый массив вещественных чисел
{
    double[] array = new double[size]; //выделим память под массив
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((random.NextDouble()) * 100, 1); //задаем рандомный массив (умножаем на 100, чтобы числа были от 0 до 100)
    }
    return array; // выводим массив
}

void PrinArray(double[] array) //Метод вывода массива
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double Difference(double[] array) // метод вычисления разницы между максимальным и минимальным значениями массива
{
    double difference = (array.Max()) - (array.Min());
    return difference;
}


double[] numArr = GenerateArray(15); //Вызываем новый массив из 15 элементов
PrinArray(numArr); // выводим массив
double diff = Difference(numArr);
System.Console.WriteLine($"Разница между максимальным и минимальным значениями = {diff}");
