﻿/* Задача 11 . Напишите программу, которая выводит случайное трехзначное число 
и удаляет вторую цифру этого числа*/
int num = new Random().Next(100,1000);
Console.Write($"{num} -> ");
Console.Write($"{num/100*10+num%10}\n");