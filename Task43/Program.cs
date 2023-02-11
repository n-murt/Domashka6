// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Введите b1: ");
        Double b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите k1: ");
        Double k1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b2: ");
        Double b2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите k2: ");
        Double k2 = Convert.ToDouble(Console.ReadLine());
        double[] array = Program.SystemOfVariables(b1, k1, b2, k2);
        Console.WriteLine($"Точка пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 - ({array[0]},{array[1]})");
    }

    static double[] SystemOfVariables(double b1, double k1, double b2, double k2)
    {
        double[] Point = new double[2];
        Point[0] = (b2 - b1) / (k1 - k2);
        Point[1] = k1 * ((b2 - b1) / (k1 - k2)) + b1;
        return Point;
    }

}