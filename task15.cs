Console.WriteLine("Введите цифру дня недели");
int num1 = int.Parse(Console.ReadLine()!);

if (num1 > 0 && num1 < 8)
{
    if (num1 == 6 || num1 == 7)
    {
        Console.WriteLine("выходной");
    }
    else
    {
        Console.WriteLine("будний");
    }
}
else
{
    Console.WriteLine("Введите цифру от 1 до 7");
}
