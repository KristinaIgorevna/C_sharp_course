void OneOfNum(int num_1)
{
    while (num_1 > 999)
    {
        num_1 /= 10;
    }
    if (num_1 > 99 && num_1 < 1000)
    {
        Console.WriteLine(num_1 % 10);
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
}
OneOfNum(16);
OneOfNum(161);
OneOfNum(161456);
OneOfNum(56798);

