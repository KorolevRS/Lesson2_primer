// Задача 59. Из двумерного массива целых чисел 
//удалить строку и столбец, на пересечении которых расположен наименьший эллемент
int[,] array = new int[5, 5];
int[,] array2 = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

for (int i = 0; i < array.GetLength(0); i++) //генерация и вывод массива
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

int im = 0;
int jm = 0;

for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        if (array[i, j] < array[im, jm])
        { im = i; jm = j; }

for (int i = 0, i2 = 0; i < array.GetLength(0); i++, i2++)
{
    for (int j = 0, j2 = 0; j < array.GetLength(1); j++, j2++)
    {
        if (i == im) i++;
        if (j == jm) j++;
        array2[i2, j2] = array[i, j];
    }
}
array = array2;

Console.WriteLine("\n");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    { Console.Write($"{array[i, j]} "); }
    Console.WriteLine();
}