// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i<=n; i++)
{
    result = result*i;
}
Console.WriteLine($"Результат выполения программы = {result}");