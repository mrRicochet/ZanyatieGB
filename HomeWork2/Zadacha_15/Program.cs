// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

//6->да
//7->да
//1->нет

System.Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());


if (num > 7 || num < 1)
{
  System.Console.WriteLine("Такого дня недели не существует");
}
else if (num > 0 & num < 6)
{
  System.Console.WriteLine("Нет. Это Рабочий день");
}
else
{
  System.Console.WriteLine("Да. Это выходной день");
}
