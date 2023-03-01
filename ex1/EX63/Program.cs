// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

string Revers(int N)
{
    if (N == 1) return N.ToString();
    else
    {
        return Revers(N - 1) + ", "+ N.ToString();
    }

}


Console.WriteLine("введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Revers(N));
