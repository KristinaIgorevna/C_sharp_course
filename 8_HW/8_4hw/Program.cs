// Задайте двумерный массив, программу которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива

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


int MinElem(int[,] arr)
{
    int min = arr[0, 0];
    int count = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    while (count < row * column)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if (min > arr[i, j]) min = arr[i, j];
            }
        }
        count++;
    }
    return min;
}

void CorrectMass(int[,] arr, int []min)
{
    int row = 0;
    int col = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j <arr.GetLength(1); j++)
         {
            if (arr[i, j] = min)
            {
                 row = i;
                 col = j;
                Console.WriteLine($"min element on {row + 1} {col + 1}");
            }
        }
     }
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (i==row || j== col) continue;
                else Console.WriteLine ($"{arr[i,j],1}");
            }
            Console.WriteLine();
        }
          Console.WriteLine();
}

    Console.WriteLine("Введите число рядов: ");
    int row = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите число колонок: ");
    int column = int.Parse(Console.ReadLine());

    int[,] arr_1 = MassNums(row, column, 1, 101);
    Print(arr_1);

    int [] mass= MinElem (arr_1);
    CorrectMass(arr_1, mass);
