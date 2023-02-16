// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в 
// массиве.

// [345, 897, 568, 234] -> 2

int[] GenerateArray(int size) //Генерируем новый массив
{
    int[] array = new int[size]; //выделим память по массив
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000); // задаем рандомный массив из трехзначных чисел
    }
    return array;
}

void PrinArray(int[] array) //Метод вывода массива
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int CheckNumber(int[] arr) // Метод подсчета четных чисел массива
{
    int result = 0; //вводим переменную
    for (int i = 0; i < arr.Length; i++) //Прогоняем все элементы массива
    {
        if (arr[i] % 2 == 0) //Если остаток от деления = 0, то число четное
        {
            result++; //Кладём его в переменную
        }
    }
    return result; // возвращаем результат
}

int[] numArr = GenerateArray(15); //Вызываем новый массив из 15 элементов
PrinArray(numArr); // выводим массив
int check = CheckNumber(numArr); //вызываем функцию счета четных чисел массива 
System.Console.WriteLine($"Количество четных чисел в массиве = {check}"); // выводим результат на экран