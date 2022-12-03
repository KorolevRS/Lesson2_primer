int[] array = { 1, 56, 21, 44, 2, 32, 85, 14, 12 };
int n = array.Length;
int find = 12;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    
    index++;
}
