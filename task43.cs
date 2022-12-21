Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2");
double k2 = double.Parse(Console.ReadLine()!);

double[] piece = Function(b1, k1, b2, k2);

Console.WriteLine(piece[0]);
Console.WriteLine(piece[1]);

double[] Function(double b1, double k1, double b2, double k2)
{
    double[] current = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    current[0] = x;
    current[1] = y;
    return current;
}
