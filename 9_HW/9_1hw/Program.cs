// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа
// в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

// Console.WriteLine("Введите число M: ");
// int M = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int N = int.Parse(Console.ReadLine());

void Nature(int M, int N)
{
    if (M > N) return;
    Nature(M, N - 1);
    if (N% 2 == 0) Console.Write($"{N},");
}
Nature(1, 10);
