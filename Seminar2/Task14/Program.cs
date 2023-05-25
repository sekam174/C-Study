// напишите программу, которая принимае
// на вход число и проверяет, кратно ли оно одновременно
// 7 и 23

// 14 -> нет        && - И
// 46 -> нет        || - ИЛИ
// 161 -> да

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if((num % 7 == 0) && (num % 23 == 0))
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно");
}