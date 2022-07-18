// задать массив заполненный случайными положительными трехзначными числами
// программу которая покажет кол-во четных чисел в массиве

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
        arr[i] = new Random().Next(99, 1000);
    }
    return arr;
}

int PosNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) 
        {
          count += 1;
        }
       
    }
    return count;
}

int[] arr_1 = MassNums(10);
Print(arr_1);
Console.WriteLine(PosNum(arr_1));
