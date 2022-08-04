// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (вводим массив с клавиатуры (т. е. через консоль :) ))
Console.WriteLine("Введите массив из 8 элементов:");

int[] arr = new int[8];
int i = 0;
while (i<8)
{
    Console.Write($"Введите {i} элемент массива: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}

int l=0;
while (l<8)
{
    Console.WriteLine(arr[l]);
    l++;
}