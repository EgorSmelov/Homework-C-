Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

int function = Power(num);
Console.WriteLine(function);

int Power(int number)
{
    int sum = 0;
    while (number >= 10)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum + number;
}