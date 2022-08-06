// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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

void SummNechet(int[] arr, out int Sum)
{
    Sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2>0)
        {
            Sum = Sum+arr[i];
        }
    }
}
int[] array = FillArrayWithRandomNumbers(10, -5, 5);
Console.WriteLine('[' + string.Join(", ", array) + ']');
SummNechet(array, out int sum1);
Console.WriteLine($"Сумма нечетных элементов = {sum1}");