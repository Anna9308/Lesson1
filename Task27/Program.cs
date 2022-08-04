// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 0;
int result = 0;
int r = 0;
while (N>0)
{
    result=N%10;
    N=N/10;
    r = r+result;
    i++;

}

Console.WriteLine($"Результат: {r}");