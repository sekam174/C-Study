// напишите программу, которая по
// заданному номеру четверти показывает
// диапазон возможных координат точек
// в этой четверти(Х и У)

// Console.WriteLine("Введите число от 1 до 4");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num == 1)
// {
//     Console.WriteLine("x > 0, y > 0");
// }
// else if(num == 2)
// {
//     Console.WriteLine("x < 0, y > 0");
// }
// else if(num == 3)
// {
//     Console.WriteLine("x < 0, y < 0");
// }
// else if(num == 4)
// {
//     Console.WriteLine("x > 0, y < 0");
// }
// else
// {
//     Console.WriteLine("Ввели не корректное число");
// }

Console.WriteLine("Введите число от 1 до 4");
int num = Convert.ToInt32(Console.ReadLine());

switch(num)
{
    case 1:
    {
        Console.WriteLine("x > 0, y > 0");
        break;
    }
    case 2:
    {
        Console.WriteLine("x < 0, y > 0");
        break;
    }
    case 3:
    {
        Console.WriteLine("x < 0, y < o");
        break;
    }
    case 4:
    {
        Console.WriteLine("x > 0, y < 0");
        break;
    }
    default:
    {
        Console.WriteLine("Ввели некорректное число");
        break;
    }
}