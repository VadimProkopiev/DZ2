﻿//Задача 21.git add Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2");
int z2 = Convert.ToInt32(Console.ReadLine());

int xa = (x1 - x2);
int ya = (y1 - y2);
int za = (z1 - z2);
double c =  Math.Pow(xa, 2);
double b =  Math.Pow(ya, 2);
double d =  Math.Pow(za, 2);
double f = Math.Sqrt(c+b+d);
Console.Write($"{f}");