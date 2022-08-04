// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = 1;

while (N>=10)
{
    N=N/10;
    result++;
}

Console.WriteLine($"Результат: {result}");