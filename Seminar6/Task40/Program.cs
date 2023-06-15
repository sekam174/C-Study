// напишите программу, которая принимает
// 3 числа и проверяет, может ли
// существовать треугольник со
// сторонами такой длины

// ТЕОРЕМА О НЕРАВЕНСТВЕ ТРЕУГОЛЬНИКА: Каждая сторона
// треугольника меньше суммы двух других сторон;

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int c = int.Parse(Console.ReadLine());

if((a < b + c)&&(b < a + c)&&(c < a + c))
{
    Console.WriteLine("Может");
}
else
{
    Console.WriteLine("Числа не подходят");
}