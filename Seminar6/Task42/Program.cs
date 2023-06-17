// напишите программу, которая будет
// преобразовывать десятичное число в двоичное

// 45 -> 101101
//  3 -> 11
//  2 -> 10

// string result = "5";
// int num = 3;
// Console.WriteLine(result + num); ->  (53) это строка

// 5 -> 101 (5%2=1; 5/2=2) (2%2=0; 2/2=1) (1%2=1; 1/2=0,5(0,5int=0))
// 3 -> 11  (3%2=1; 3/2=1) (1%2=1; 1/2=0)
//          result   num1              int

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

string result = " ";

while(num > 0)
{
    result = num % 2 + result;
    num = num / 2;
}
Console.WriteLine(result);
