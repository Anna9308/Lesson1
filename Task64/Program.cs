// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumbers(number);
void PrintNumbers(int N)
{
    if (N<1) return;
    Console.Write(N + " ");
PrintNumbers(N-1);
}
