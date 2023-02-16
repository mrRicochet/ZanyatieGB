// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int size) //Генерируем новый массив
{
    int[] array = new int[size]; //выделим память под массив
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-30, 30); // задаем рандомный массив с диапазоном от -30 до 30
    }
    return array; // выводим массив
}

void PrinArray(int[] array) //Метод вывода массива
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int SumOddNumbers(int[] arr)
{
    int result = 0; //вводим переменную
    for (int i = 0; i < arr.Length; i++) //Прогоняем все элементы c нечетными индексами
    {
        if (i % 2 != 0) //Если остаток от деления не равен 0, то индекс нечетный
        {
            result = result + arr[i]; //Кладём его в переменную
        }
    }
    return result; // возвращаем результат
}

int[] numArr = GenerateArray(15); //Вызываем новый массив из 15 элементов
PrinArray(numArr); // выводим массив
int sumOdd = SumOddNumbers(numArr); //вызываем функцию счета чисел с нечетными индексами 
System.Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {sumOdd}"); // выводим результат на экран