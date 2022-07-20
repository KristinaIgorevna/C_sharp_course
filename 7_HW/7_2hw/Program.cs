// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


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
            arr[i, j] = new Random().Next(1, 20);
        }
    }
    return arr;
}

Console.WriteLine("Введите номер строки: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int j = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[3, 4];
FillArray(arr);

if (i > arr.GetLength(0) || j > arr.GetLength(1))
    {
        Console.WriteLine($"{i}{j}->Такого элемента нет!");
    }
    else
    {
        Console.WriteLine($" {i}{j} -> {arr[i - 1, j - 1]}");
    }
PrintArray(arr);

