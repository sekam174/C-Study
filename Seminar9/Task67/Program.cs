// Напишите программу, которая будет на вход
// принимать число и возвращать сумму его цифр

// 453 -> 12
//  45 -> 9

//                 453 / 10 = 45  ->  45 / 10 = 4  ->  4 / 10 = 0
// 453 % 10 = 3 ->  45 % 10 = 5   ->   4 % 10 = 4

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int PrintNumbers(int num1)
{
    if(num1 == 0)
    {
        return 0;
    }
    return(num1 % 10 + PrintNumbers(num1 / 10));
}
Console.WriteLine(PrintNumbers(num));