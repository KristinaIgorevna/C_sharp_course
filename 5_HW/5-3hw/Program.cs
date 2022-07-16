// задайте массив вещественных чисел
// найти разницу между макс и мин элементом массива

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-99, 99);
    }
    return arr;
}

int MaxMinNum(int[] arr)
{

    int max = arr[0];
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i]<min)
        {
            min = arr[i];
            //Console.WriteLine (min);
        }
    }
    Console.WriteLine (max);
    Console.WriteLine (min);
  
    return max - min;
}

int[] arr_1 = MassNums(5);
Print(arr_1);
Console.WriteLine(MaxMinNum(arr_1));
