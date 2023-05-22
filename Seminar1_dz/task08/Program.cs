// напишите программу, которая на вход
// принимает число (N), а на выходе показыват
// все чётные числа от 1 до (N)

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int evenNum = 2;

while(evenNum <= num)
{
    Console.Write(evenNum + " ");
    evenNum = evenNum + 2;
}





