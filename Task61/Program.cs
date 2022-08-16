// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
Console.Write("Введите количество строк треугольника Паскаля = ");
int count = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [count,count];

int k = 1;
matrix[0,0] = 1;
for (int i = 1; i<count; i++)
{
        matrix[i,0] = 1;
        matrix[i,k] = 1;
    for (int j = 1; j<k; j++)
    {

        matrix[i,j] = matrix[i-1,j-1]+matrix[i-1,j];
    }
    k++;
}
int l = 1;
for (int i=0; i < count; i++) 
{
    for (int m=0; m<(count-i); m++)
    {
        Console.Write(" ");
    }
    for (int j=0; j < l; j++)
    {

    Console.Write(matrix[i,j] + " ");
    }
    l++;
    Console.WriteLine();
}