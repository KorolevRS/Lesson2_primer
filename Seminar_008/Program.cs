// Sпреобразование числа в текст и работа с массивом букв как числовые значения
int a;
Console.Write($"Введите число: ");
string user = Console.ReadLine()!; //считал число
int.TryParse(user, out a); //убедились что это число а
user = a.ToString(); // перобразовали число в текст
int[] array = new int[user.Length]; //объявили численный массив с длинной строки user

for (int i = 0; i < array.Length; i++) // присваиваем каждомо элементу числового масива символ из строки
    array[i] = int.Parse(user[i].ToString());// присваиваем каждому элементу числового массива символ из строки

for (int i = 0; i < array.Length; i++) //вывод массива на экран
    Console.WriteLine($"{array[i]} ");
