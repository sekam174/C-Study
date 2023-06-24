// Задайте значение N. Напишите програамму,которая выведет
// все натуральные числа в промежутке от 1 до N

// N = 5 -> " 1, 2, 3, 4, 5 "
// N = 6 -> " 1, 2, 3, 4, 5, 6 "

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int startNum = 1;

Console.WriteLine(PrintNumbers(startNum, num));

string PrintNumbers(int num1, int num2)
{
    if(num1 == num2)
    {
        return num1.ToString();
    }
    return(num1+" "+PrintNumbers(num1 + 1, num2));
}