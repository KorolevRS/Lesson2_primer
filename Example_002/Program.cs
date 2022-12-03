// See https://aka.ms/new-console-template for more information
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 21;
int b1 = 2;
int c1 = 103;
int a2 = 24;
int b2 = 52;
int c2 = 418;
int a3 = 59;
int b3 = 22;
int c3 = 47;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int maximum = Max(max1, max2, max3);
int maximum = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2), 
    Max(a3, b3, c3));
Console.WriteLine(maximum);
