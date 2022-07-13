Console.Write("Введите первое число: ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N2 = Convert.ToInt32(Console.ReadLine());
    int del = N1%N2;
if (del==0)
{
    Console.WriteLine("Кратно");
}
else
{

    Console.WriteLine($"Не кратно, остаток {del}");
}