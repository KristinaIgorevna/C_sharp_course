// напишите программу которая найдет точку пересечения двух прямых
// заданных уравнениями у=к1*x+b1 y=k2*x+b2


void dot(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка перенсечения: ({x};{y})");


}
dot(3, 5, 2, 4);