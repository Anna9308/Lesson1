Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
    Console.Write("max = ");
    Console.WriteLine(number1);
    Console.Write("min = ");
    Console.Write(number2);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(number2);
    Console.Write("min = ");
    Console.Write(number1);
}