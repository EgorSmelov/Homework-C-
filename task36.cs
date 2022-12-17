Console.WriteLine("Введите размер массива");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение");
int minvalue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение");
int maxvalue = int.Parse(Console.ReadLine()!);

int[] arr = FillArray(N, minvalue, maxvalue);

PrintArray(arr);
int oddresult = CountResultPos(arr);
Console.WriteLine(oddresult);

int CountResultPos(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

int[] FillArray(int N, int minvalue, int maxvalue)
{
    int[] array = new int[N];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minvalue, maxvalue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
