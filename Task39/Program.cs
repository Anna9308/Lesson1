// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
void PrintArray(int[] arr)
{
    for (int i=0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] ReversArray(int[] arr)
{
    int[] ArrayRevers = new int[arr.Length]; 
    for (int i = 0; i < arr.Length; i++)
    {
        ArrayRevers[i] = arr[arr.Length-1-i]; 

    }
    return ArrayRevers;
}




int[] array = FillArrayWithRandomNumbers(4, 1, 10);
PrintArray(array);
int[] ArrayRevers = ReversArray(array);
Console.WriteLine();
PrintArray(ArrayRevers);