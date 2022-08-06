// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// Method

void FindCrossPoint(double f1, double m1, double f2, double m2)
{
    if (f1 != f2)
    {
        double x = (m2 - m1) / (f1 - f2);
        double y = f1 * x + m1;
        Console.WriteLine("Координаты точки пересечения прямых: x = {0}, y = {1}", x, y);
    }
    else Console.WriteLine("Прямые не пересекаются");
}

// Code

Console.WriteLine("Задайте коэффициент k1 для прямой y = k1 * x + b1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Задайте коэффициент b1 для прямой y = k1 * x + b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Задайте коэффициент k2 для прямой y = k2 * x + b2");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Задайте коэффициент b2 для прямой y = k2 * x + b2");
double b2 = double.Parse(Console.ReadLine());

FindCrossPoint(k1, b1, k2, b2);

