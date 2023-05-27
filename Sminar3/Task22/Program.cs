// напишите программу, которая принимает
// на вход число (N) и выдаёт
// таблицу квадратов чисел от 1 до N
//
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;

if(count > num)
{
    Console.WriteLine("Не соответствует условиям");
}

while(count <= num)
{
    Console.Write(Math.Pow(count, 2)+ " ");
    count = count + 1;
}
