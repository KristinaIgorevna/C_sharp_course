// программа, которая принимает на вход число N и
// выдает таблицу кубов чисел от 1 до N
void N(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.Write($"{Math.Pow(count, 3)} ");
        count++;
    }
}
N(3);

