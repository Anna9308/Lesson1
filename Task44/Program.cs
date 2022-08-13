// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
int[] fib = new int [N];
fib[0]=0;
fib[1]=1;
while (i<N)
{
fib[i] = fib[i-1]+fib[i-2];
i++;
}

void PrintArray(int[] arr)
{
    for (int i=0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

PrintArray(fib);