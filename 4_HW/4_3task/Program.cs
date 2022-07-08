// напишите программу которая задает массив из 8 элементов случайными числами 
// и выводит их на экран

void FillArray(int[] collection)
{
    int length = collection.Length;
int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,99);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count=col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}");
        Console.Write($"{,}");
        position++;
    }

}
int[] array = new int[8];
FillArray(array);
PrintArray(array);