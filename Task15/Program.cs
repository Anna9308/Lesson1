Console.Write("Введите число дня недели ");
int number = Convert.ToInt32(Console.ReadLine());
if (number<8)
{
    if (number==6 || number ==7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
}
else{
    Console.WriteLine("Такого дня не существует");
}