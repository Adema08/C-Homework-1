// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (n < 2)
{
    Console.Write("Нет четных чисел");
}
else
{
    for (i = 2; i <= n; i += 2)
    Console.Write($"{i} ");
}
