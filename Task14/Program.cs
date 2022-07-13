Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if ((N % 7 == 0) && (N % 23 == 0))
{
    Console.WriteLine("Да");
}
else
{

    Console.WriteLine("Нет");
}