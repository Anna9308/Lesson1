// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
int[,] FillRandomMatrix(int lines = 5, int columns = 3, int leftRange = 1, int rightRange = 5)
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

int [,] newMatrix = new int [Matrix.GetLength(1),Matrix.GetLength(0)];

for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {

            newMatrix[i, j] = Matrix[j, i];
        }
    }
Console.WriteLine();
PrintMatrix(newMatrix);