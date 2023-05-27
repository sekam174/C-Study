//напишите программу, которая
//выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет

// 645 -> 5
// 32679 -> 6
// 78 -> третьей цифры нет

int num = new Random().Next(10, 10000000);
Console.WriteLine(num);

if(num / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (num > 1000)
    {
        num = num / 10;
    }
    Console.WriteLine(num % 10);
}