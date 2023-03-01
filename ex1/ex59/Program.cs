﻿// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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

int[] MinElement(int[,] array)
{
    int[] result = new int[2];
    int min = array[0, 0];
    int minRow = 0;
    int minCol = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                minRow = i;
                minCol = j;

            }
        }
    }
    result = new int[] { minRow, minCol };
    return result;
}
int[,] DelArray(int[,] array, int[] minIndexes)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    
    int row=0;
    int col = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minIndexes[0]) continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j != minIndexes[1])
            {
                result[row, col] = array[i, j];
                col++;
            }
            
        }
        col=0;
        row++;
        
    }
    return result;
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


int[,] array2D = GetArray(row, col, 1,20);

PrintArray(array2D);
Console.WriteLine();
int[] minIndex = MinElement(array2D);
int[,] result =  DelArray(array2D,minIndex);
PrintArray(result);