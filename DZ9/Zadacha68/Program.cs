﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write ("Введите целое число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите целое число n ");
int n = Convert.ToInt32(Console.ReadLine());

int SumRec(int m , int n)
{
    if (m==0) return n+1;
    if (m>0 && n==0) return SumRec(m-1, 1);
    if (m>0 && n>0) return SumRec(m-1, SumRec(m, n-1));
    return 0;
}

Console.WriteLine($"A(m,n) = {SumRec(m,n)}");