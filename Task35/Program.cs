// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
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

void AmountElementsSegment(int[] arr, out int Count)
{
    Count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>=10 && arr[i]<=99)
        {
            Count++;
        }
    }
}


int[] array = FillArrayWithRandomNumbers(123, 1, 1000);
Console.WriteLine('[' + string.Join(", ", array) + ']');
AmountElementsSegment(array, out int Count1);
Console.WriteLine($"Количество элементов в отрезке [10,99] = {Count1}");
