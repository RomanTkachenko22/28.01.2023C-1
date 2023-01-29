/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNum = int.Parse(Console.ReadLine());



if(firstNum > secondNum && firstNum > thirdNum)
{
    
    Console.WriteLine($"Число {firstNum} максимальное");
}
if(secondNum > firstNum && secondNum > thirdNum)
{
    
    Console.WriteLine($"Число {secondNum} максимальное");
}
if(thirdNum > secondNum && thirdNum > firstNum)
{
    
    Console.WriteLine($"Число {thirdNum} максимальное");
}

Console.ReadKey();