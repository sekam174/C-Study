// напишите программу, которая
// принимает на вход число (N)
// и выдаёт произведение чисел от 1 до N

// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Div());

int Div()
{
    int result = 1;
    int count = 1;

    while(count <= num)
    {
        result = result * count;
        count++;
    }
    return result;
}

// Console.WriteLine(Div());