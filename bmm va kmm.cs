using System;

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" bozorg tarin makhraj moshtarak: " + BM(x, y));

int BM(int a, int b)
{
    int temp;
    while (true)
    {
        if (b == 0) break;

        temp = a % b;
        a = b;
        b = temp;
    }
    return a;
}