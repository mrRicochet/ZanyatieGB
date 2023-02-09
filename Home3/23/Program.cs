// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//Напишите программу, которая принимает 
//на вход число (N) и выдаёт таблицу кубов 
//чисел от 1 до N.

//3 -> 1, 4, 9.
//5 -> 1, 8, 27, 64, 125.

int InputNumber(string str)
{
    System.Console.WriteLine
    (str);
    return Convert.ToInt32(Console.ReadLine());
}

int N = InputNumber("Введите число N: ");

for(int num = 1; num <= N; num++)
{
    System.Console.Write(Math.Pow(num, 3) + ", ");
} 
