// Задайте двумерный массив.
// Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

int[,] FillRandomMatrix(int lines = 3, int columns = 6, int leftRange = 0, int rightRange = 9)
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
int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
 
int temp;
for (int i=0; i<Matrix.GetLength(0); i++)
{
for (int j = 0; j < Matrix.GetLength(1) - 1; j++)
{
    for (int k = j + 1; k < Matrix.GetLength(1); k++)
    {
        if (Matrix[i,j] > Matrix[i,k])
        {
            temp = Matrix[i,j];
            Matrix[i,j] = Matrix[i,k];
            Matrix[i,k] = temp;
        }
    }
}
}
 
Console.WriteLine("Вывод отсортированного массива");
PrintMatrix(Matrix);