﻿// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i<=a; i++)
{
    sum = sum + i;
}
Console.WriteLine($"Результат выполения программы = {sum}");