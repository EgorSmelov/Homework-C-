Console.WriteLine("Введите число");
int N = Math.Abs(int.Parse(Console.ReadLine()!));

for (int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 3) + ", ");
}
