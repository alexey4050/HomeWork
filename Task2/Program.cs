// Программа принимающая на вход 2 числа и выдает, какое число большее, а какое меньшее//
int a;
int b;
Console.WriteLine("Введите 2 числа: ");

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}