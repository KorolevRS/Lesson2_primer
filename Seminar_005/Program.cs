/* Задача 12 . Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. Если второе число некартное первому 
то выводить остаток от деления*/
int a,b;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out b);
if(a%b==0)
    Console.WriteLine($"кратно");
else
    Console.WriteLine($"не кратно, остаток от деления = {a%b}");