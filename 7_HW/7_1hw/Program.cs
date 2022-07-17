// задайте двумерный массив размером m*n
// заполненный случайными вещественными числами


void PrintArray(double[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(new Random().Next(-999, 1000) + new Random().NextDouble(), 2);
        }
    }
    return arr;
}

double[,] arr = new double [3,4];
FillArray(arr);
PrintArray(arr);
