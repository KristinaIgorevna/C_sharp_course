// принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве

double AB (double x1, double y1, double z1,double x2, double y2, double z2)
{
return  Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
}
AB(3,6,8,2,1,-7);
Console.WriteLine (AB(3,6,8,2,1,-7));