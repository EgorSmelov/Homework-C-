Console.WriteLine("Введите размер массива");
int N =int.Parse(Console.ReadLine()!);

int[] arr = FillArray(N, 100, 999);

PrintArray(arr);
int oddresult = CountResult(arr);
Console.WriteLine(oddresult);

int CountResult(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        result++;
    
    }
    return result;
}

int[] FillArray(int size, int minBorder, int maxBorder)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minBorder, maxBorder);
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
