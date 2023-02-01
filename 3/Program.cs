// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("введите число ");
int a = Convert.ToInt32(Console.ReadLine());
double c = a%2;
if ( c == 0)
{
    Console.WriteLine("да");
}
else
{
   Console.WriteLine("нет"); 
}