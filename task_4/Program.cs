// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter 1st number: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter 2nd number: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter 3rd number: ");
double c = Convert.ToDouble(Console.ReadLine());
double max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine($"max: {max}");