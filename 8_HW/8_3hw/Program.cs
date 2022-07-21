// Задайте две матрицы, напишите программу, которая будет находить произведение двух матриц

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


int [,] TwoMatrix (int[,] arr1, int [,] arr2)
{
    int length= arr1.GetLength(1);
  int [,]matr= new int [length,length];
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++) 
       {
           for (int k=0; k<length;k++)
           {
               matr[i,j]+=arr1[i,k]*arr1[k,j];
           }
       }
    }
   return matr;
}

int from=1;
int to=10;
Console.WriteLine("Введите число строк и столбцов: ");
int row = int.Parse(Console.ReadLine());
int column = row;


int[,] matrix1=  MassNums(row, column, from,to);
Print(matrix1);

int[,] matrix2= MassNums(row, column, from,to);
Print(matrix2);

int [,]multi= TwoMatrix (matrix1,matrix2);
Print (multi);
