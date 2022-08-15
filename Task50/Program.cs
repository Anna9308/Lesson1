// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int n = 5;
int m = 5;
int [,] matrix = new int [n,m];

for (int i=0; i < m; i++) 
{
    for (int j=0; j < n; j++)
    {
        matrix[i,j] = i+j;
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите i = ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите j = ");
int l = Convert.ToInt32(Console.ReadLine());

if (k>n || l>m)
{
    Console.WriteLine("Элемента с таким индексом нет");
}
else
{
    Console.WriteLine(matrix[k,l]);
}