// Напишите программу замену элементов: положительные на отрицательные и наоборот
int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
}
Print(array);
Console.WriteLine();

Inverse(array);

Print(array);
Console.WriteLine();
void Inverse(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
        arr[i] = -arr[i];
}




void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}