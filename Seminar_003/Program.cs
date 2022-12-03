/* Задача 9 . Напишите программу, которая выводит случайное число из отрезка [10,99]
 и показывыет наибольшую цифру числа*/

int num = new Random().Next(10, 90);
Console.Write($"{num} -> ");

if (num / 10 > num % 10)
    Console.Write($"{num / 10}");
else
    Console.Write($"{num % 10}");

Console.WriteLine();
