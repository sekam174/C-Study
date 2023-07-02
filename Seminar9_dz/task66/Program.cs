// Задайте значения М и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от М до M.

// M = 1; N = 15  -> 120
// M = 4; N = 8   -> 30

Console.WriteLine("Введите значение M");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение N");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumber(num,number));

int PrintNumber(int num1, int num2)
{
    if(num1 > num2)
    {
        Console.Write("Нет решения: ");
        return 0;
    }
    if (num1 == num2)
    {
        Console.Write("Идентичные значения: ");
        return num1;
    }
    return(num1 + PrintNumber(num1 + 1, num2));
}
