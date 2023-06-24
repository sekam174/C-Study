// Задайте значения М и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от М до N

// M = 1; N = 5 -> " 1, 2, 3, 4, 5 "
// M = 4; N = 8 -> " 4, 5, 6, 7, 8 "

Console.WriteLine("Введите число М");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

string PrintNum(int num1, int num2)
{
    if(num1 > num2)
    {
        return "нет решения";
    }
    if(num1 == num2)
    {
        return num1.ToString();
    }
    return(num1+" "+PrintNum(num1+1,num2));
}
Console.WriteLine(PrintNum(num, number));
