﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// // 32679 -> 6

// Console.Write("Введите любое число - ");
// int n = Convert.ToInt32 ( Console.ReadLine());
int n=new Random().Next(1, 1000000);
Console.WriteLine(n);
int NumLen = (int)Math.Log10(n) + 1;
Console.WriteLine($"Количество цифр в числе,  {NumLen}");
if (NumLen>1 && NumLen<3) Console.WriteLine("Третьей цифры нет");
int i = 1;
int x = 0;
if (n>99 && n<1000)
   {
    x = n%10;
    Console.Write("Тетья цифра, " + x);
    } 
while (i <= NumLen)
{
   n = n/10; 
   
   if (n>99 && n<1000)
   {
    x = n%10;
    Console.Write(n +" ");// Уменьшение числа до 3 символов
    Console.Write("Тетья цифра, " + x);
    break;
   } 
   i++;
}
