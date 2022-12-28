
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
PrintNto1(N);

void PrintNto1(int N)
{
    if (N == 0)
    {
        return;
    }
    Console.Write(N + " ");
    PrintNto1(N - 1);
}
