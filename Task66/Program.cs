// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
PrintNumbers(M, N);

void PrintNumbers(int M1, int N1)
{
    if (N1<M1) return;
    PrintNumbers(M1, N1-1);
   sum = sum + N1;
   // Console.Write(N1 + " ");
}

Console.WriteLine("Сумма элементов от М до N = " + sum);