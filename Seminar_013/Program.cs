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

for (int i = 0; i < array.Length; i++)
    if (array[i] == b)
    {
        Console.WriteLine($"да");
        return; //можно написать break
    }
Console.WriteLine("Нет");