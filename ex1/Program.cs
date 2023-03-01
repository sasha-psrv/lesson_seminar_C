// 1. Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// Console.Clear();
// Console.Write("введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// int b = 0;
// for (int i = 0; i <= N; i++)
// {
//     b += i;
// }
// Console.WriteLine(b);


// 2.Возведите число А в натуральную степень B используя цикл

// Console.Clear();
// Console.Write("введите число: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.Write("введите степень: ");
// int B = int.Parse(Console.ReadLine()!);

// int r = 1;

// for (int i = 0; i < B; i++)
// {
//     r*=A;
// }
// Console.WriteLine(r);


// 3.Определить количество цифр в числе

Console.Clear();
Console.Write("введите число: ");
int n = int.Parse(Console.ReadLine()!);
int r = 0;
while(n!=0)
{
    n=n/10;
    r++;
}
Console.WriteLine(r);