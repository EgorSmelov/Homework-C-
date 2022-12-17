
Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение");
int max = int.Parse(Console.ReadLine()!);


double[] a2 = FillArray(num, min, max);
double counts = minmax(a2);
PrintArray(a2);
Console.WriteLine(" Число " + counts);


double[] FillArray(int msz, int fmin, int fmax)
{
    double[] field = new double[msz];
    for (int i = 0; i < field.Length; i++)
    {
        field[i] = new Random().Next(fmin, fmax + 1);
    }
    return field;
}

double minmax(double[] arr)
{
    double minFind = 100;
    double maxFind = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (minFind > arr[i])
        {
            minFind = arr[i];
        }
        if (maxFind < arr[i])
        {
            maxFind = arr[i];
        }
    }
    Console.WriteLine(minFind + " " + maxFind);
    return maxFind - minFind;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}