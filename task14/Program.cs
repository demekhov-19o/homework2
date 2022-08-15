// Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int a = 7;
int b  = 23;
string txtResult =  "";

if (number % a == 0 && number % b == 0) txtResult = "кратно обоим числам";
else if (number % a != 0 && number % b != 0) txtResult = "не кратно ни одному из чисел";
else if (number % a == 0) txtResult = $"кратно только числу {a}";

else txtResult = $" кратно только числу { b }";

System.Console.WriteLine($"Проверить кратность числа {number} числам {a} и {b} ");
System.Console.WriteLine();
System.Console.WriteLine($"Число {number} {txtResult} ");
System.Console.WriteLine();