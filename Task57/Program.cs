// Составить частотный словарь элементов двумерного массива.
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

int [,] sourseMatrix = FillRandomMatrix();
PrintMatrix(sourseMatrix);

int [] CountingArray = new int [10];

        for (int i = 0; i < sourseMatrix.GetLength(0); i++)
        {
           for (int j = 0; j < sourseMatrix.GetLength(1); j++)
        {
         CountingArray[sourseMatrix[i,j]]++;
        }
        }

          for (int i = 0; i < CountingArray.Length; i++)
        {        
            Console.WriteLine($"Количество повторений для {i} = {CountingArray[i]}");
        }
