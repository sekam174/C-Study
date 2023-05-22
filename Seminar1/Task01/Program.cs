// напишите программу, которая
// на вход принимает два числа и проверяет
// является ли первое число квадратом второго

// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());

if(a == b * b)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}