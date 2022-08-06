// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
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

void Amount(int[] arr, out int Count)
{
    Count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0)
        {
            Count++;
        }
    }
}

int[] array = FillArrayWithRandomNumbers(10, 100, 999);
Console.WriteLine('[' + string.Join(", ", array) + ']');
Amount(array, out int Count1);
Console.WriteLine($"Количество четных элементов = {Count1}");