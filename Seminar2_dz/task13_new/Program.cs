//напишите программу, которая
//выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет

// 645 -> 5
// 32679 -> 6
// 78 -> третьей цифры нет

int num = new Random().Next(10, 999999);
Console.WriteLine(num);

if(num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
if(num >= 100 && num <= 1000)
{
    int num1 = num % 10;
    Console.WriteLine(num1);
}
if(num >= 1000 && num <= 10000)
{
    int num2 = num / 10 % 10;
    Console.WriteLine(num2);
}
if(num >= 10000 && num <= 100000)
{
    int num3 = num / 100 % 10;
    Console.WriteLine(num3);
}
if(num >= 100000 && num <= 1000000)
{
    int num4 = num / 1000 % 10;
    Console.WriteLine(num4);
}