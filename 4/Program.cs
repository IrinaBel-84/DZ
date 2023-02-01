// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count <= n)
{
    Console.Write($"{count} ");
    count = count + 2;
}
