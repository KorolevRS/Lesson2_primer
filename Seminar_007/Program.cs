// See https://aka.ms/new-console-template for more information
int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(10);
Print(array);

int sum = 0;
for (int i = 0; i < array.Length / 2; i++) //с 8 по 16 строку подсчитывает сумму элементов массива
// используя зеркальные элементы
{
    sum += array[i];
    sum += array[array.Length - i - 1];
}
if (array.Length % 2 != 0)
    sum += array[array.Length / 2];
Console.WriteLine(sum);

void Print(int[] arr) //Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
