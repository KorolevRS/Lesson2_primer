// Программа которая находит 
// заданное число в рандомном массиве
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
}
Print(array);
Console.WriteLine();
int a;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

Find(a, array);

void Find(int b, int[] array)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == b)
        {
            Console.WriteLine($"да");
            return; //можно написать break
        }
    Console.WriteLine("Нет");
}
void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}