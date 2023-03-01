// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] copyArr(int[] inArray)
{
    int[] arr = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        arr[i]= inArray[i];
    }
    return arr;
}


int[] arr = GetArray(5,-10,10);
int[] CopyArr = copyArr(arr);
Console.WriteLine(String.Join(", ", arr));
Console.WriteLine(String.Join(", ", CopyArr));
