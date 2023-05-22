// напишите программу,которая
// на вход принимает три числа и
// выдаёт максимальное из этих чисел

// 2,3,7 -> 7
// 2,9,5 -> 9

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
Console.Write("max= ");
Console.WriteLine(max);
