// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter 1st number: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter 2nd number: ");
double b = Convert.ToDouble(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"max = {a}");
}
else if (a == b)
{
    Console.WriteLine("Numbers are equal");
}
else
{
    Console.WriteLine($"max = {b}");
}