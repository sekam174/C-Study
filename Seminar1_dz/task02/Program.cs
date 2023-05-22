// напишите программу, которая
// на вход принимает два числа и
// выдаёт какое число больше, а какое меньше

// a = 5; b = 7 -> max = 7
// a = 9; b = 2 -> max = 9


Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    int max = a;
    Console.WriteLine($"max -> {a}");
}
else if(b > a)
{
    int max = b;
    Console.WriteLine($"max -> {b}");
}