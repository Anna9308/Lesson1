Console.Write("Введите первое число: ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N2 = Convert.ToInt32(Console.ReadLine());
if ((N1 == N2*N2) || (N2 == N1*N1))
{
    Console.WriteLine("Да");
}
else
{

    Console.WriteLine("Нет");
}