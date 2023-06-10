// напишите цикл, который
// принимает на вход два числа(А и В)
// и возводит число А в натуральную степень В.

// 3, 5 -> 243
// 2, 4 -> 16
// для меня эта задача оказалась самой сложной
// (сам не додумался ввести третью переменную)

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

int Div()
{
    int count = 1;
    int num3 = 1;

    while(count <= num2)
    {
        num3 = num3 * num1;
        count = count +1;
    }
    return num3;
}
Console.WriteLine(Div());