// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных

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

int[] Convert2DTo1(int[,] array)
{
    int[] convert = new int[array.GetLength(0) * array.GetLength(1)];
    int k = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            convert[k++] = array[i, j];

        }
    }
    return convert;
}
void sortConvert(int[] inArray)
{
    int temp;
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                temp = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = temp;
            }
        }
    }

}

void CountResult(int[] InArray)
{
    int count = 1;
    for (int i = 1; i < InArray.Length; i++)
    {
        if (InArray[i] == InArray[i - 1])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"количество {InArray[i - 1]},встречается {count}");
            count = 1;
        }
    }
    Console.WriteLine($"количество {InArray[InArray.Length - 1]},встречается {count}");
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

int[,] array2D = GetArray(row, col, 0,3);

PrintArray(array2D);
Console.WriteLine();
int[] convert = Convert2DTo1(array2D);
sortConvert(convert);
CountResult(convert);
