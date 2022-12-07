// Вводим числа и присваиваем их в статический массив. 
//void InreaseArray увеличивает наш массив на 1
// int a = 1;
// int[] array = new int[0];

// while (a != 0)
// {
//     Console.Write($"Введите [{array.Length}] элемент: ");
//     int.TryParse(Console.ReadLine()!, out a);
//     if (a != 0)
//     {
//         InreaseArray(ref array);
//         array[array.Length - 1] = a;
//     }
// }
// for (int i = 0; i < array.Length; i++)
//     Console.Write($"{array[i]} ");

// void InreaseArray(ref int[] arr)
// {
//     int[] arr2 = new int[arr.Length + 1];
//     for (int i = 0; i < arr.Length; i++)
//         arr2[i] = arr[i];
//     arr = arr2;
// }
// Console.WriteLine();
// Использование динамического массива List в той же задаче
int a = 1;
List<int> array = new List<int>();
while (a != 0)
{
    Console.Write($"Введите [{array.Count}] элемент: ");
    int.TryParse(Console.ReadLine()!, out a);
    if (a != 0)
        array.Add(a);
}
for (int i = 0; i < array.Count; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();