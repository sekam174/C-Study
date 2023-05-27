// напишите программу, которая                                     |y
// принимает на вход координаты точки(Х и У)                     2 | 1    
// причём X не равно 0 и У не равно 0                        ------|------ x
// и выдаёт номер четверти плоскости,                            3 | 4
// в которой находится эта точка                                   |

Console.WriteLine("Введите координату Х");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату У");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("1");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("2");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("3");
}
else
{
    Console.WriteLine("4");
}