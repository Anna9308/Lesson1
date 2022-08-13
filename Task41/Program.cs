// Пользователь вводит с клавиатуры M чисел в одну линию (не используем Enter).
//Числа разделены пробелами. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите числа: ");
int[] numbers = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).ToArray();

void PrintArray(int[] arr)
{
    for (int i=0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

PrintArray(numbers);


int count = 0;
for (int i=0; i < numbers.Length; i++)
    {
        if (numbers[i]>0)
        {
            count++;
        }
    }
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0 = {count}");