﻿//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите k1 ");
double k1 = Convert.ToDouble(Console.ReadLine() ?? "");
Console.WriteLine("Введите b1 ");
double b1 = Convert.ToDouble(Console.ReadLine() ?? "");
Console.WriteLine("Введите k2 ");
double k2 = Convert.ToDouble(Console.ReadLine() ?? "");
Console.WriteLine("Введите b2 ");
double b2 = Convert.ToDouble(Console.ReadLine() ?? "");
if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Прямые совпадают");
} 
else
{
    if (k1==k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double x = (b2-b1)/(k1-k2);
        double y = (k1*(b2-b1))/(k1-k2)+b1;
        Console.WriteLine($"({x};{y}) - точка пересечения двух пярмых ");
    }   
}