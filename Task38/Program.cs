//  Задайте с клавиатуры массив вещественных (double) чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите массив из {n} элементов:");
double[] arr = new double[n];
int i = 0;
while (i<n)
{
    Console.Write($"Введите {i} элемент массива: ");
    arr[i] = Convert.ToDouble(Console.ReadLine());
    i++;
}

double MaxElement (double[] array)
{
    double Max = array[0];
     for (int i = 0; i < array.Length; i++)
     {
        if (array[i]>Max)
        {
            Max=array[i];
        }
     } 
     return Max;
}
double MinElement (double[] array1)
{
    double Min = array1[0];
     for (int i = 0; i < array1.Length; i++)
     {
        if (array1[i]<Min)
        {
            Min=array1[i];
        }
     }
     return Min;
}

double Result = MaxElement(arr) - MinElement(arr);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(Result);

