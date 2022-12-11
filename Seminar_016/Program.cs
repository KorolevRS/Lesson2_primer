// Задача 39. Напишите программу, которая перевернет одномерный массив
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
}
Print(array);
Console.WriteLine();
for (int i = 0; i < array.Length / 2; i++)
{
    (array[i], array[array.Length - i - 1]) = (array[array.Length - i - 1], array[i]);
    // строчка выше: меняет местами элементы в масиве
}
Print(array);
Console.WriteLine();



void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}