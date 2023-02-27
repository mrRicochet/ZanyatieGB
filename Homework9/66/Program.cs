// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;

int SumNumbers(int num1, int num2)
{
    if (num1 <= num2)
    {
        sum += num1;
        num1++;
        SumNumbers(num1, num2);
    }
    else return 0;
    return sum;
}
System.Console.WriteLine(SumNumbers(m, n));