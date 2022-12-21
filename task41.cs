
Console.WriteLine("Введите количество чисел");
int numberCount = int.Parse(Console.ReadLine()!);

Console.WriteLine(CountPositive(numberCount));


int CountPositive(int numberCount)
{
    int counter = 0;
    for (int i = 0; i < numberCount; i++)
    {
        Console.Write($"{i + 1}  ");
        if (int.Parse(Console.ReadLine()!) > 0) counter++;
    }
    return counter;
}
