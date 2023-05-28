// напишите программу, которая принимает
// на вход пятизначное число и проверяет,
// является ли оно палиндромом
//
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num / 10000;
int num2 = num / 1000 % 10;

if(num1 == num % 10 && num2 == num / 10 % 10)
{
    Console.WriteLine("Число палиндром");
}
else
{
    Console.WriteLine("Не является палиндромом");
}