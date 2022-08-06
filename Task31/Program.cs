// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.


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

void sumPositiveAndNegative(int[] arr, out int sumPositive, out int sumNegative)
{
    sumPositive = 0;
    sumNegative = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumPositive += arr[i];
        }
        else
        {
            sumNegative += arr[i];
        }
    }
}

int[] array = FillArrayWithRandomNumbers (12, -9, 9);
sumPositiveAndNegative (array, out int sumP, out int sumN);

Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine($"Сумма положительных чисел = {sumP}");
Console.WriteLine($"Сумма отрицательных чисел = {sumN}");