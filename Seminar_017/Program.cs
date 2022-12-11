// Задача 39. Напишите программу, которая перевернет двумерный массив
int[,] array = new int[5, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
    }

}
Print(array);
Console.WriteLine();

for (int n = 0; n < (array.GetLength(0) * array.GetLength(1) / 2); n++)
//идем от 0 элемента до середины массива и меняем первый с последним элементом
{
    int i = n / array.GetLength(1);
    int j = n - i * array.GetLength(1);
    (array[i, j], array[array.GetLength(0) - i - 1, array.GetLength(1) - j - 1]) =
     (array[array.GetLength(0) - i - 1, array.GetLength(1) - j - 1], array[i, j]);
}

Print(array);
Console.WriteLine();
// for (int i = 0; i < array.GetLength(0) / 2; i++)
// {
//     for (int i = 0; i < array.GetLength(1) / 2; i++)
//     (array[i], array[array.Length - i - 1]) = (array[array.Length - i - 1], array[i]);
//     // строчка выше: меняет местами элементы в масиве
// }















void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}