// Программа, которая на вход принимает число(N), а на выходе показывает все четные числа от 1 до N.
//5 -> 2,4
//8-> 2,4,6,8
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int result = 1; result <= num; result++)
{
    if (result %2 ==0)
    {
    Console.WriteLine(result); 
    }
}    



