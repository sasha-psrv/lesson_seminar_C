// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.



bool CheckEngl(int a, int b, int c)
{
    return a + b > c & a + c > b & c + b > a;
}
Console.WriteLine("введите a:");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите b:");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите c:");
int C = int.Parse(Console.ReadLine()!);


if (CheckEngl(A, B, C))
{
    Console.WriteLine("существует");
} else {
    Console.WriteLine("не существует");
}
