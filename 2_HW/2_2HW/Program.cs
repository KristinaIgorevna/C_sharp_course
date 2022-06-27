// выводит случайное трехзначное число и удаляет вторую цифру этого числа


int Num_3 = new Random().Next(100, 999);
int Num_1 = (Num_3  / 100);
int Num_2 = (Num_3 % 10);
Console.WriteLine(Num_3);
Console.Write(Num_1);
Console.Write(Num_2);



