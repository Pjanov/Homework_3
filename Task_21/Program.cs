/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53    */

Console.WriteLine("Введите координаты первой точки:");
Console.Write("x: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Координата точки A ({x1} ,{y1} ,{z1})");

Console.WriteLine("Введите координаты второй точки:");
Console.Write("x: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
double z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Координата точки B ({x2} ,{y2} ,{z2})");

double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) +
           Math.Pow(y2 - y1, 2) +
           Math.Pow(z2 - z1, 2)); // Distance = √(x2 - x1)² + (y2 - y1)² + (z2 - z1)²

Console.WriteLine($"Расстояние между точками AB = {Math.Round(dist, 2)}");

/*
Math.Sqrt(double value): возвращает квадратный корень числа value
Math.Pow(double a, double b): возвращает число a, возведенное в степень b.
Math.Round(double a, int b): возвращает число a, округленное до определенного 
количества знаков после запятой, представленного параметром b.     */