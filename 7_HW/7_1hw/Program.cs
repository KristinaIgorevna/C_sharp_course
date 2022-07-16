// задайте двумерный массив размером m*n
// заполненный случайными вещественными числами


void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetHashCode(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; i < column_size; j++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
    }
}
    double[,] MassNums(int row, int column, int from, int to)
    {
        double[,] arr = new double[row, column];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                arr[i, j] = new Random().Next(from, to);
            }
        }
        return arr;
    }

int[,] arr_1 = MassNums(3, 4, -99, 100);
Print (arr_1);
     
