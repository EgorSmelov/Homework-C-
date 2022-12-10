Console.WriteLine("Введиет число A ");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введиет число B ");
int numB = int.Parse(Console.ReadLine()!);


int stepen = Power(numA, numB);
Console.WriteLine(stepen);


int Power(int numberA, int numberB)
{
    int riders = numberA;
    for (int i = 1; i < numberB; i++)
    {
        riders = riders * numberA;
    }
    return riders;
}