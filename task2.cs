Console.WriteLine("Введите первое число ");
string num1 = Console.ReadLine()!;
int num1int = int.Parse(num1);

Console.WriteLine("Введите второе число ");
string num2 = Console.ReadLine()!;
int num2int = int.Parse(num2);

if (num1int > num2int)
{
Console.WriteLine(num1int + " больше " + num2int);
}

else if (num2int > num1int)
{
    Console.WriteLine(num2int + " больше " + num1int);
}

else
{
    Console.WriteLine(" числа равны ");
}