// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
System.Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число C: ");
int numC = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (numA > max){
    max = numA;
}
if (numB > max){
    max = numB;
}
if (numC > max){
    max = numC;
}
else{
    System.Console.WriteLine("max=" + max);
}