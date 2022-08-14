// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите k1");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double d = Convert.ToDouble(Console.ReadLine());

if (a==b) 
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{
   double x = (d-c)/(a-b);
   double y = (a*d-b*c)/(a-b);
   Console.WriteLine($"Точка пересечения двух прямых: ({x}, {y})");
}
