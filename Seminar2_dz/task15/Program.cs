// напишите программу, которая принимает на вход
// цифру, обозначающую день недели и проверяет
// является ли этот день выходным

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите день недели");
// int day = Convert.ToInt32(Console.ReadLine());

int day = new Random().Next(1, 8);
Console.WriteLine(day);

if((day % 6 == 0) || (day % 7 == 0))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}