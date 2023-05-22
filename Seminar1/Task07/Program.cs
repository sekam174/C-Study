// напишите программу, которая
// принимает на вход трёхзначное число, а
// на выходе показывает последнюю цифру этого числа

// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if((num > 99) && (num < 1000))
{
    int num2 = num % 10;
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("это не трёхзначное число");
}
