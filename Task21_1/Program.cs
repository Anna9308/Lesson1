Console.WriteLine("Введите X первой точки: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y первой точки: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z первой точки: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X второй точки: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y второй точки: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z второй точки: ");
int zb = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2)+Math.Pow((zb-za),2));

Console.WriteLine(d);