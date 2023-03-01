// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
int[,] Invers(int[,] array)
{
    int[,] temp = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            temp[i, j] = array[j, i];
        }
    }
    return temp;
}



void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }

}




Console.WriteLine("введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, -10, 10);

PrintArray(array2D);
Console.WriteLine();
if (row == col)
{
    int[,] inversedArray = Invers(array2D);
    PrintArray(inversedArray);
}
else
{
    Console.WriteLine("строки и столбцы не совпадают");
}