// не используя рекурсию, выведите
// первые N чисел Фибоначи,
// первые два числа Фибоначи: 0 и 1

// Если N = 5 -> 01123
// Если N = 3 -> 011
// Если N = 7 -> 0112358

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int firstNum = 0;
int secondNum =1;

Console.Write(firstNum+" " + secondNum+" ");

for(int i = 3; i <= num; i++)
{
    int newNum = firstNum + secondNum;
    Console.Write(newNum+" ");

    firstNum = secondNum;
    secondNum = newNum;
}
