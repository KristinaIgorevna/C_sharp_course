// Задайте двумерный массивю Напишите программу, 
// котораяя упорядочит по убыванию элементы каждой строки двумерного массива

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}


int[,] MinMass(int[,] arr)
{
    int count = 0;
    while (count <= arr.GetLength(0) * arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    (arr[i, j], arr[i, j + 1]) = (arr[i, j + 1], arr[i, j]);
                }
            }

        }

count++;
    }
    return arr;
}

Console.WriteLine("Введите число рядов: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число колонок: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] arr_1 = MassNums(row, column, 1, 101);
Print(arr_1);

MinMass(arr_1);
Print(arr_1);

