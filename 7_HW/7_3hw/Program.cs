// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int[,] arr)
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

int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void Average(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    double sum = 0;
      
      for (int j = 0; j < columns; j++)
     {
        for (int i = 0; i < rows; i++)
        {
           sum += arr[i, j];
            
         }
         Console.WriteLine (sum /rows);
         sum=0;
     }
    //return sum/rows;
}
// Console.WriteLine("Enter the number of rows: ");
// int row = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the number of columns: ");
// int column = int.Parse(Console.ReadLine());
int[,] arr_1 = new int[2, 3];
FillArray(arr_1);
PrintArray(arr_1);
Average(arr_1);



