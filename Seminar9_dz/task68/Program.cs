// Напишите программу вычисления функции Аккермана с помощью рекурсии
// Даны два неотрицательных числа m и n.

// m = 2; n = 3  -> A(m,n)=9
// m = 3; n = 2  -> A(m,n)=29

// m\n   0    1    2    3    4

//  0 |  1    2    3    4    5     n + 1

//  1 |  2    3    4    5    6     n + 2 = 2 + (n + 3) - 3

//  2 |  3    5    7    9    11    2n + 3 = 2 * (n + 3) - 3

//  3 |  5    13   29   61   125   2(n + 3) - 3


Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if(m == 0)
    {
        return n+1;
    }
    else if(n == 0)
    {
        return Akkerman(m-1, 1);
    }
    else
    {
        return Akkerman(m-1, Akkerman(m, n-1));
    }
}
Console.Write($"Функция Аккермана равна: {Akkerman(m,n)}");
