Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату a");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату b");
int b = int.Parse(Console.ReadLine()!);

int[,] matrix = Create2DArray(m, n, 1, 10);
Print2DArray(matrix);
ReturnValue(matrix);

int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");

        }
        Console.WriteLine();
    }
}

void ReturnValue(int[,] matrix)
{

    if (a>matrix.GetLength(0) || b>matrix.GetLength(1))
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.Write(matrix[a,b]);
    }
    
}

