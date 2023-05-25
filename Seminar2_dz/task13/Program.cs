//напишите программу, которая
//выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет

// 645 -> 5
// 32679 -> 6
// 78 -> третьей цифры нет

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if(num >= 100 && num <= 999)
{
    int num1 = num % 10;
    Console.WriteLine(num1);
}
else if(num >= 1000 && num <= 9999)
{
    int num2 = num / 10 % 10;
    Console.WriteLine(num2);
}
else if(num >= 10000 && num <= 99999)
{
    int num3 = num / 100 % 10;
    Console.WriteLine(num3);
}
else if(num >= 100000 && num <= 999999)
{
    int num4 = num / 1000 % 10;
    Console.WriteLine(num4);
}
else if(num >= 1000000 && num <= 9999999)
{
    int num5 = num / 10000 % 10;
    Console.WriteLine(num5);
}