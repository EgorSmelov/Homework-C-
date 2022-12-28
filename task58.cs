Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимум");
int minMatr = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимум");
int maxMatr = int.Parse(Console.ReadLine()!);

int[,] matrixA = CreateMatrixA(m, n, minMatr, maxMatr);
int[,] matrixB = CreateMatrixB(m, n, minMatr, maxMatr); 
// int[,] matrixC = new int[matrixA, matrixB];
Console.WriteLine();
PrintMatrixA(matrixA);
Console.WriteLine();
PrintMatrixB(matrixB);
Console.WriteLine();
PrintMatrixC(MatrixMultiply(matrixA, matrixB));





int[,] CreateMatrixA(int m, int n, int min, int max)
{
    int[,] matrixA = new int[m, n];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            matrixA[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrixA;
}

void PrintMatrixA(int[,] matrixA)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {

        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            Console.Write($"{matrixA[i, j]} ");

        }
        Console.WriteLine();
    }
}

int[,] CreateMatrixB(int m, int n, int min, int max)
{
    int[,] matrixB = new int[m, n];

    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixB[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrixB;
}

void PrintMatrixB(int[,] matrixB)
{
    for (int i = 0; i < matrixB.GetLength(0); i++)
    {

        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            Console.Write($"{matrixB[i, j]} ");

        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiply(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;
            for (int k = 0; k < matrixA.GetLength(0); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }

        }
    }
    return matrixC;
}
void PrintMatrixC(int[,] matrixC)
{
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {

        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            Console.Write($"{matrixC[i, j]} ");

        }
        Console.WriteLine();
    }
}