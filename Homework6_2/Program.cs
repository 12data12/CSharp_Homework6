// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Enter b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

if (k1==k2 || k1==k2 && b1==b2)
{
    Console.Write("Two lines are pararrel or coincident");
}
else
{
Console.Write($"Two lines intersect at the point with the coordinates ({x};{y})");
}