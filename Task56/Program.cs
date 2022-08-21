// Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] FillRandomMatrix(int lines = 5, int columns = 3, int leftRange = 0, int rightRange = 9)
{
    int[,] RandomMatrix = new int[lines, columns];

    for (int i = 0; i < RandomMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < RandomMatrix.GetLength(1); j++)
        {
            RandomMatrix[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return RandomMatrix;
}

void PrintMatrix(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Matrix = FillRandomMatrix();
PrintMatrix(Matrix);
Console.WriteLine();
int[] sum = new int[Matrix.GetLength(0)];

 for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        sum[i]=0;
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
           
            sum[i] = sum[i] + Matrix[i,j];
        }
       
        Console.WriteLine(sum[i]);
         
    }

    int  min = sum[0];
    int minIndex = 0;
    for (int i = 0; i < sum.Length; i++)
    {
 if (sum[i]<min)
        {
            min = sum[i];
            minIndex = i;
        }
                //Console.WriteLine(minIndex + " наименьшая строка");
    }
        Console.WriteLine(minIndex+1 + " наименьшая строка");
