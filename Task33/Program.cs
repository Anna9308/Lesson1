// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
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

void FindNumber(int[] arr, int N)
{
    bool Result = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == N)
        {
            Result = true;
        }
    }
    if (Result)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

int[] array = FillArrayWithRandomNumbers(9, 0, 9);
Console.WriteLine('[' + string.Join(", ", array) + ']');
FindNumber (array, 3);
