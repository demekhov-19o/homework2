﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 1000 && a > 99)
{
int b = a / 10;
int result = b % 10;
Console.Write(result);
}
else
Console.WriteLine("Ввели не трехзначное число");
