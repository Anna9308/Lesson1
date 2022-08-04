// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int[] arr = new int[8];
Random rand = new Random();
int i = 0;
while (i<arr.Length)
{
    arr[i] = rand.Next(0,2);

    i++;
}
Console.WriteLine(string.Join(", ", arr));