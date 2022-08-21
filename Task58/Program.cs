// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] Matrix1 = FillRandomMatrix();
int[,] Matrix2 = FillRandomMatrix();
PrintMatrix(Matrix1);
Console.WriteLine();
PrintMatrix(Matrix2);
int[,] Matrix3 = new int[Matrix1.GetLength(0),Matrix1.GetLength(1)];
for (int i = 0; i < Matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix3.GetLength(1); j++)
        {
            Matrix3[i,j] = Matrix1[i,j]*Matrix2[i,j];
        }
    }
    Console.WriteLine();
    PrintMatrix(Matrix3);