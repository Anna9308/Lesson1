// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int [,,] Matrix = new int [2,2,2];
 for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
        for (int k = 0; k < Matrix.GetLength(2); k++)
        {
            Matrix[i, j, k] = new Random().Next(10, 99);
             Console.WriteLine(Matrix[i, j, k] + "(" + i + "," + j + "," + k + ")");
        }
    }
    }
