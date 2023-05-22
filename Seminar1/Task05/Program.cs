// напишите программу, которая
// на вход прининимает одно число(N)
// а на выходе показывает все целые числа
// в промежутке от (-N) до (N)

// 4 -> "-4,-3,-2,-1,0,1,2,3,4"
// 2 -> "-2,-1,0,1,2"

Console.WriteLine("Введите целое натуральное число");
int num = Convert.ToInt32(Console.ReadLine());

int negNumber = -1 * num;
while(negNumber <= num)
{
    Console.Write(negNumber +" ");
    negNumber = negNumber + 1;
}