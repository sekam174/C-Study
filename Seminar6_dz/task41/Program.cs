// пользователь вводит с клавы М чисел.
// посчитайте, сколько чисел больше 0 ввёл пользователь

// 0, 7, 8, -2, -2  -> 2
//-1, -7,  56, 89, 22 -> 3

Console.Write("Введите количество элементов массива = ");
int size = Convert.ToInt32(Console.ReadLine());
int[]num = new int[size];

void RandNumbers(int[]num) // Заполняем массив
{
    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите число = ");
        num[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void Power(int[]num) // Находим эл-ты больше нуля
{
    int result = 0;
    for(int i = 0; i < num.Length; i++)
    {
        if(num[i] > 0)
        {
            result += 1;
        }
        else if(num[i] <=0)
        {

        }
    }
    Console.WriteLine($"Количество положительных чисел = {result}");
}
void PrintArray(int[]num) // Выводим массив
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i]+" , ");
    }
    Console.Write("]");
}
RandNumbers(num);
Power(num);
Console.Write("Массив = ");
PrintArray(num);