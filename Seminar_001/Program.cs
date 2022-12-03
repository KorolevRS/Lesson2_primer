/* Задача 5 . Напишите программу, которая на вход принимает одно число (N),
//а на выходе показывает все целые числа в промежутке от -N до N*/

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

// int n = -N;
// while (n<=N)
// {
//     Console.Write($"{n} ");
//     n++;
// }
for (int n = -N; n <= N; n++)
{
    Console.Write($"{n} ");
}
Console.WriteLine();
