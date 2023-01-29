/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine());

if (firstNum > secondNum)
{
  Console.WriteLine($"Число {firstNum} больше, чем число {secondNum}" );  
}
if (secondNum > firstNum)
{
    Console.WriteLine($"Число {secondNum} больше, чем число {firstNum}" );
}

Console.ReadKey();