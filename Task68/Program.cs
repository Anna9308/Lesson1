// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine(A(2,3));
static int A(int m, int n)
{
     if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return A(m - 1, 1);
    if (m > 0 && n > 0)
        return A(m - 1, A(m, n - 1));
    return A(n,m);
}

