
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(Akkerman(m, n));

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m != 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}