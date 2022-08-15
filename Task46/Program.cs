// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
Console.WriteLine("Задайте размерность двумерного массива mxn");
Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [m,n];

for (int i=0; i < m; i++) 
{
    for (int j=0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(-100,100);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}