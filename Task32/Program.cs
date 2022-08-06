// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
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

void Change(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *=-1;
    }
    Console.WriteLine('[' + string.Join(", ", arr) + ']');
}

int[] array = FillArrayWithRandomNumbers (5, -9, 9);

Console.WriteLine('[' + string.Join(", ", array) + ']');
Change (array);