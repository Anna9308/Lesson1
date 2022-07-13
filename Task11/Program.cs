int number = new Random().Next(100,1000);
Console.WriteLine(number);
int digit1 = number / 100;
int digit2 = number / 10 % 10;
int digit3 = number % 10;
int result = digit1*10 + digit3;
Console.WriteLine(result);