// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

internal class Program
{
  private static void Main(string[] args)
  {
    double InputCoef(string text)
    {
      System.Console.Write(text);
      return Convert.ToDouble(Console.ReadLine());
    }

    double[] intersectionPoint(double b1, double k1, double b2, double k2)
    {
      double[] arrayXY = new double[2];
      if (k1 == k2)
        System.Console.WriteLine("Прямые совпадают, либо параллельны.");
      else
      {
        arrayXY[0] = (b2 - b1) / (k1 - k2);
        arrayXY[1] = k1 * arrayXY[0] + b1;
      }
      return arrayXY;
    }

    void PrintArray(double[] ArrayForPrint)
    {
      System.Console.WriteLine("(" + string.Join(", ", ArrayForPrint) + ")");
    }

    double k1 = InputCoef("Введите коэффициент k для первой прямой: ");
    double b1 = InputCoef("Введите коэффициент b для первой прямой: ");
    double k2 = InputCoef("Введите коэффициент k для второй прямой: ");
    double b2 = InputCoef("Введите коэффициент b для второй прямой: ");

    double[] Point = intersectionPoint(b1, k1, b2, k2);

    if (k1 != k2)
      PrintArray(Point);
  }
}