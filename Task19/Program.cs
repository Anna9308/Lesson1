Console.WriteLine("Введите пятизначное число ");
string N = Convert.ToString(Console.ReadLine());
Console.WriteLine(N);
if ((N[0]==N[4]) && (N[1]==N[3]))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}