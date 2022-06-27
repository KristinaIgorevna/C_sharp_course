void OneOfNum(int num_1)
{
    if (num_1 > 99 && num_1 < 1000)
    {
        Console.WriteLine(num_1 % 10);
    }

    else if (num_1 > 999)
    {
        Console.WriteLine(num_1 / 10);
    }

    else
    {
        Console.WriteLine("третьей цифры нет");
    }
}
OneOfNum(16);
OneOfNum(161);
OneOfNum(1617345);