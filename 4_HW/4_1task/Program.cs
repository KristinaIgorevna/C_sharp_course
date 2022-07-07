// напишите цикл, который принимает на вход два числа А ,В и возводит А в натуральную степень В


int PowNum(int a, int b)
{
    int n_pow = a;
    {
        for (int i = 2; i <= b; i++)
        {
            Console.WriteLine(Math.Pow(a, i));
        }
        return n_pow;
    }
}

Console.WriteLine(PowNum(3, 4));