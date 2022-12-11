// Задача 40. Напишите программу, которая принимает на вход 3 числа
//  и проверяет существует такой треугольник или нет
Console.WriteLine($"Введите длины строн треуголника: ");

string[] Lines = Console.ReadLine()!.Split(' '); // Записывает с введенную с экрана информацию
// в массив Lines, причем элементы отделяет на строке "пробелом"(то что в Split задано)
int[] nums = new int[Lines.Length];

for (int i = 0; i < Lines.Length; i++)
    int.TryParse(Lines[i], out nums[i]);

if (IsTriang(nums[0], nums[1], nums[2]))
    Console.WriteLine("Является");
else
    Console.WriteLine("не является");

bool IsTriang(int a, int b, int c)
{
    return (a < b + c && b < a + c && c < a + b);
}