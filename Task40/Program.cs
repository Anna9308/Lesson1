// Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
Console.WriteLine("Введите длину стороны А:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны B:");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны C:");
int C = Convert.ToInt32(Console.ReadLine());

if (A>(B+C))
    Console.WriteLine("Такого треугольника не существует");
else
    if (B>(A+C))
        Console.WriteLine("Такого треугольника не существует");
    else
        if (C>(A+B)) 
            Console.WriteLine("Такого треугольника не существует");
else
Console.WriteLine("Треугольник существует");
