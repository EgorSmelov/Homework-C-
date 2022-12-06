Console.WriteLine("Введите число ");
int number1 = int.Parse(Console.ReadLine()!);
if ((number1 >= 100) && (number1 < 1000))   
{
    int firstDigit = number1 % 100;
    int secondDight = firstDigit / 10;
    Console.WriteLine(secondDight);
}
else
{
    Console.WriteLine("Введите трехзначное число");
}