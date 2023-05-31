// напишите программу, которая
// принимает на вход число и
// выдаёт количество цифр в числе

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
string text = Console.ReadLine();
Console.WriteLine(Length());
int Length()
{
    int length = text.Length;
    return length;
}

// Console.WriteLine(Length());
