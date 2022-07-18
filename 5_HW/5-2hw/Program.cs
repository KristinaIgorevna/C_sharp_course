// одномерный массив, заполненный случайными числами
// найти сумму элементов , стоящих на нечетных позициях


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
        arr[i] = new Random().Next(1, 50);
    }
    return arr;
}

int PositionNum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (i % 2 != 0)
        {
            sum+= arr[i];
            //Console.WriteLine(sum+= arr[i]);
            //Console.WriteLine();
        }

    }
   // Console.WriteLine(sum);
   return sum;
}

int[] arr_1 = MassNums(8);
Print(arr_1);
Console.WriteLine(PositionNum(arr_1));