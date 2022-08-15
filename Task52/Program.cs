// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int n = 5;
int m = 5;

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

double sum = 0;
for (int j=0; j < n; j++) 
{
    for (int i=0; i < m; i++)
    {
        sum = sum + matrix[i,j];
    }
    double avg = sum/m;
    Console.Write(avg + " ");
    sum = 0;
}

