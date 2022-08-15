// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
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
        matrix[i,j] = new Random().Next(1,5);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}

for (int i=0; i < m; i++) 
{
    for (int j=0; j < n; j++)
    {
        if (i%2==0 && j%2==0)
            {
            matrix[i,j] = matrix[i,j]*matrix[i,j];
            }
    Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}