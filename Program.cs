﻿// Таблица кубов от 1 до N.

Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());
int i = 1;

while (i <= N)
{
    Console.Write(Math.Pow(i,3) + " ");
    i++;
}