﻿// напишите программу, которая будет
// принимать на вход два числа и выводить
// является ли второе число кратным первому.
// если число 2 не кратно числу 1, то
// программа выводит остаток от деления

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    //Console.WriteLine("Остаток от деления" + num1 % num2);
    Console.WriteLine($"остаток от деления {num1 % num2}");
}