﻿/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
Console.Write("Введите  число: ");
int num = int.Parse(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine($"Число {num} является чётным");
} 
if(num % 2 != 0)
{
    Console.WriteLine($"Число {num} является нечётным");
} 

Console.ReadKey();
