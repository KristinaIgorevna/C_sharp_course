// выводит случайное трехзначное число и удаляет вторую цифру этого числа


int SecondNum = new Random().Next(100, 999);


Console.WriteLine(SecondNum);
Console.WriteLine(SecondNum % 10 > SecondNum / 10);



