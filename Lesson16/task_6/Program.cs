/*Завдання 6
Створіть структуру, яка описує точку у тривимірній системі координат. Організуйте можливість складання двох точок через використання навантаження оператора +.*/

using System;

public struct Point3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Point3D operator +(Point3D p1, Point3D p2)
    {
        return new Point3D(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
    }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}

public class Program
{
    public static void Main()
    {
        Point3D point1 = new Point3D(12.0, 22.0, 8.0);
        Point3D point2 = new Point3D(5.0, 17.0, 2.0);
        Point3D result = point1 + point2;

        Console.WriteLine($"Точка 1: {point1}");
        Console.WriteLine($"Точка 2: {point2}");
        Console.WriteLine($"Результат: {result}");
    }
}
