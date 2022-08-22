// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumbers(number);
void PrintNumbers(int N)
{
    if (N< 1) return;
    PrintNumbers(N-1);
    Console.Write(N + " ");
}
