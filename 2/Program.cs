//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine($"{max}");