// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string str = string.Empty;
while (n>0)
{
    str = n%2+str;
    n=n/2;
}
Console.WriteLine(str);