Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
N= Math.Abs(N);
if (N<100)
{
    Console.Write("Третьей цифры нет");
}
//if (N>99 && N<1000)
//{
//    Console.Write(N % 10);
//}
//else
//{
 //   string N1 = N.ToString();
//    Console.Write(N1[2]);
//}
else
{
    while (N>999)
    {
        N = N/10;
    }

Console.Write(N % 10);
}
