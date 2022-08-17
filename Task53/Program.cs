// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Console.WriteLine("Задайте размерность двумерного массива mxn");
int m = 5;
int n = 5;

int [,] matrix = new int [m,n];

for (int i=0; i < m; i++) 
{
    for (int j=0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(1,10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i=0; i < m; i++) 
{
    for (int j=0; j < n; j++)
    {
        int number = matrix[0,j];
        matrix[0,j] = matrix[m-1,j];
        matrix[m-1,j] = number;
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}