// принимает на вход пятизначное число и 
// проверяет является ли оно палиндромом


void Num(string num)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine("да");
    }
    else Console.WriteLine("нет");
}

Num("12421");
