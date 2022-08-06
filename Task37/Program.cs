// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
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

void MultiplyCouple(int[] arr)
{
    int[] P = new int[arr.Length/2 + arr.Length%2];
    for (int i = 0; i < arr.Length/2; i++)
    {
        P[i] = arr[i]*arr[arr.Length-i-1];
            if (arr.Length%2>0)
        {
            P[P.Length-1]=arr[arr.Length/2];
        }
    }

    
    Console.WriteLine('[' + string.Join(", ", P) + ']');
}

int[] array = FillArrayWithRandomNumbers(5, -5, 5);
Console.WriteLine('[' + string.Join(", ", array) + ']');
MultiplyCouple(array);