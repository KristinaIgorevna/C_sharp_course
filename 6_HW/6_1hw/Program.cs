// пользователь вводит с клавиатуры М чисел
//посчитать сколько чисел > 0 ввел



int [] array = Array.ConvertAll (Console.ReadLine().Split(), int.Parse);
{

int count=0;
for (int i=0; i<array.Length; i ++)
{
    if (array[i] >0) 
    {
       count ++; 
    }
}

   Console.WriteLine (count); 
}
