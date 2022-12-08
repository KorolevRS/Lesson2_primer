// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9,9]. 
//  Найдите сумму отрицательных и 
//  положительных элементов массива

int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 9);
}
Print(array);
Console.WriteLine();

int neg = 0;
int pos = 0;

foreach (int element in array) // Цикл foreach работает только со значениями (без идексов этих значений)
{
    pos += element > 0 ? element : 0; // тернарные операторы (аналог if)
    neg += element < 0 ? element : 0;
}
// for (int i = 0; i < array.Length; i++)
// {
//     pos += array[i] > 0 ? array[i] : 0; // тернарные операторы (аналог if)
//     neg += array[i] < 0 ? array[i] : 0;
//     // if (array[i] > 0)
//     //     pos += array[i];
//     // else
//     //     neg += array[i];
// }
Console.WriteLine($"Сумма положительных = {pos}\nСумма отрицательных = {neg}");


void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}