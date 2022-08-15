// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
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
        matrix[i,j] = i+j;
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}