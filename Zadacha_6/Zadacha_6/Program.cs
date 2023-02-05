// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N%2==0){
    System.Console.Write("Да");
}
else{
    System.Console.Write("Нет");
}