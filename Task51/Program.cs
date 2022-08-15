// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
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

int sum = 0;
for (int i=0; i < m; i++) 
{
    for (int j=0; j < n; j++)
    {
        if (i==j) 
        {
            sum = sum + matrix[i,j];
        }
    }
}

    Console.WriteLine($"Сумма = {sum}");