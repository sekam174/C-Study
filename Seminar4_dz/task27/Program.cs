// напишите программу, которая принимает
// на вход число и выдаёт сумму цифр числа

// 452 -> 11
// 82  -> 10
//9012 -> 12

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int Sum()
{
    int result = 0;
    while(num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}
Console.WriteLine($"Сумма цифр числа {Sum()}");