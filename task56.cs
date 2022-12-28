Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимум");
int minMatr = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимум");
int maxMatr = int.Parse(Console.ReadLine()!);

double[,] matrix = Create2DArray(m, n, minMatr, maxMatr);
Print2DArray(matrix);
Console.WriteLine();
Console.WriteLine( "Минимальная строка равна: " + MinSumString(matrix) );


double[,] Create2DArray(int m, int n, int min, int max)
{
    double[,] matrix = new double[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((max - min) * new Random().NextDouble() + min, 2);
        }
    }
    return matrix;
}

void Print2DArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");

        }
        Console.WriteLine();
    }
}

double MinSumString(double[,] matrix)
{
    double[] sumString = new double[matrix.GetLength(0)];
    // double min = double.MaxValue;
    double min = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumString[i] += matrix[i, j];
        }
        if (min == 0)
            min = sumString[i];
        if (min > sumString[i])
            min = sumString[i];
    }
    return Math.Round((min), 2);
}