// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void changeSign(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        inArray[i] +=i;
    }
}


int[] array = GetArray(10, -10, 10);
Console.WriteLine(String.Join(", ", array));
changeSign(array);
Console.WriteLine(String.Join(", ", array));