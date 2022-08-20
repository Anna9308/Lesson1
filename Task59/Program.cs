// Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int[,] FillRandomMatrix(int lines = 3, int columns = 3, int leftRange = 0, int rightRange = 9)
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

void PrintMatrix (int[,] Array)
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

int [,] Matrix = FillRandomMatrix();
PrintMatrix(Matrix);
Console.WriteLine();
int min = Matrix[0,0];
int k = 0;
int l = 0;
for (int i = 0; i<Matrix.GetLength(0); i++)
{
    for (int j = 0; j<Matrix.GetLength(1); j++)
    {
        if (Matrix[i,j]<min)
        {
            min = Matrix[i,j];
            k = i;
            l=j;
        }

    }
}

for (int i = 0; i<Matrix.GetLength(0); i++)
{
    if (i==k) continue;
    for (int j = 0; j<Matrix.GetLength(1); j++)
    {
        if (j == l) continue;
        Console.Write(Matrix[i, j] + " ");
    }
    Console.WriteLine();
}