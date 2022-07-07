﻿//Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату x1 первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x2 второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y1 первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2 второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z1 первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2 второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)), 2);
Console.WriteLine("Расстояние между точками: " + distance);