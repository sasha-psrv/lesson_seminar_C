// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.Clear();


string Revers(int N, int M)
{
    if (N == M) return N.ToString();
    else
    {
        return Revers(N - 1,M) + ", "+ N.ToString();
    }

}




Console.WriteLine("введите число: ");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(Revers(N,M));