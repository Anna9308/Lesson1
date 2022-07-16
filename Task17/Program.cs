Console.WriteLine("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x==0 || y==0) Console.WriteLine("x и/или y равен 0, невозможно определить четверть");
else
{
    if (x>0 && y>0) Console.WriteLine("Эта точка находится в первой четверти");
    if (x<0 && y>0) Console.WriteLine("Эта точка находится во второй четверти");
    if (x<0 && y<0) Console.WriteLine("Эта точка находится в третьей четверти");
    if (x>0 && y<0) Console.WriteLine("Эта точка находится в четвертой четверти");
}
