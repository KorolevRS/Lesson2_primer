/* Задача 5 . Напишите программу, которая на вход принимает трехзначное число 
и на выходе показывает послдеднюю цифру этого числа*/

/*Console.Write($"Введите число: ");
string number = Console.ReadLine()!;
Console.WriteLine($"Цифра = {number[2]}");*/


int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);
Console.WriteLine($"Цифра = {N % 10}");