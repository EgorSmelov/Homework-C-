
void PrintArray(double[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] CreateArray(int x, int y, int fmin, int fmax)
{
    double[,] field = new double[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            field[i, j] = Math.Round((new Random().NextDouble() * (fmax - fmin) + fmin), 2);
        }

    }
    return field;
}

double[,] matrix = CreateArray(3, 4, 0, 10);
PrintArray(matrix);


