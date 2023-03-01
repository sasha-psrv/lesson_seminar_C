// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}


bool findNumber(int[] inArray, int number)
{
    foreach (int element in inArray)
    {
        if (element == number)
            return true;
    }
    return false;
}


int[] array = GetArray(5, -10, 10);
Console.WriteLine(String.Join(", ", array));

Console.WriteLine("введите число: ");
int N = int.Parse(Console.ReadLine()!);

if (findNumber(array, N))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
