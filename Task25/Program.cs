// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите А: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B: ");
int B = Convert.ToInt32(Console.ReadLine());

int pow = 1;

for (int i =0; i<B; i++)
{
 pow = pow*A;
}
Console.WriteLine(pow);