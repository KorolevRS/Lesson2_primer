// Задача 26 
// Напишите програму, которая принимает на вход число и выдает количество цифр
int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.WriteLine($"Колличество цифр в числе {a} = {a.ToString().Length} ");

// int k = 0;
// while (a > 0) //Математический способ решения задачи
// {
//     a /= 10;
//     k++;
// }
// Console.WriteLine(k);