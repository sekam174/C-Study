// напишите программу, которая
// на вход принимаетчисло и выдаёт
// является ли число чётным(делится бе остатка)

// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    int evenNum = num % 2;
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


