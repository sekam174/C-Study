// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии:

// N = 5  -> "5, 4, 3, 2, 1"
// N = 8  -> "8, 7, 6, 5, 4, 3, 2, 1";

System.Console.WriteLine("Введите знеачение N");
int num = Convert.ToInt32(Console.ReadLine());
int startNum = num;
int stopNum = 1;

System.Console.WriteLine(PrintNumbers(startNum,stopNum));

string PrintNumbers(int startNum, int stopNum)
{
    if(startNum == stopNum)
    {
        return startNum.ToString();
    }
    return(startNum+" "+PrintNumbers(startNum-1,stopNum));
}
