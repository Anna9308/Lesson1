Console.WriteLine("Введите X первой точки: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y первой точки: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X второй точки: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y второй точки: ");
int yb = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya));

Console.WriteLine(d);