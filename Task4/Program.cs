﻿// Программа, которая на вход принимает число и выдает, является ли число четным

int a;
Console.WriteLine("Введите число: ");

a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)

{
    Console.WriteLine("четное число");
}
else
{
    Console.WriteLine("нечетное");
}
