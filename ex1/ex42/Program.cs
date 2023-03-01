// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


string detcToBin(int dec)
{
    string result = "";
    while (dec > 0)
    {
        result = (dec % 2).ToString() + result;
        dec /= 2;
    }
    return result;
}

Console.WriteLine("введите число:");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(detcToBin(N));