// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или
// сообщает, что третьей цифры нет.

//645->5
//78->третьей цифры нет
//32679->6


System.Console.WriteLine("Введите число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if(num <= 100)
{
    System.Console.WriteLine("У введеного числа третьей цифры нет");
}

for(int i = num; i > 100; i = i/10)
{
    if(i>100 & i<1000)
    {
        int res = i%10;
        System.Console.WriteLine($"У введеного числа {num} третья цифра {res}");
    }
}