// напишите программу, которая принимает на вход чосли и выдает сумму цифц в числе

int SumNum (int num)
{
int n_sum=0;
while (num>0)
{
    n_sum+= num %10;
    num/=10;
}
return n_sum;
}
Console.WriteLine (SumNum(452));