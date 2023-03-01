// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

int NumbersToNumber(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else
    {
        return n % 10 + NumbersToNumber(n / 10);
    }
}


Console.WriteLine("введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumbersToNumber(N));