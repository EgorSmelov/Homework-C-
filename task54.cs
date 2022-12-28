Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимум");
int minMatr = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимум");
int maxMatr = int.Parse(Console.ReadLine()!);

double[,] matrix = Create2DArray(m, n, minMatr, maxMatr);
Console.WriteLine();
Print2DArray(matrix);
MoreToLess(matrix);
Console.WriteLine();
Print2DArray(matrix);


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

double[,] MoreToLess(double[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] > matrix[i, k])
                {
                    double temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
    return matrix;
}
