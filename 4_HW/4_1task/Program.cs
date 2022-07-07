// напишите цикл, который принимает на вход два числа А ,В и возводит А в натуральную степень В


int B (int num)
{
    int A = 3;
    {
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine(Math.Pow(A, i));

    }
    return A;
    }
}

Console.WriteLine(A(5));