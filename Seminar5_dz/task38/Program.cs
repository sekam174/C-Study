// задайте массив вещественных чисел
// найдите разницу между max и min эл-тами массива

// [3,22; 4,2; 1,15; 77,15; 65,2] = 77,15 - 1,15 = 76

Console.WriteLine("Введите кол-во эл-тов массива");
int num = Convert.ToInt32(Console.ReadLine());

double[]array = new double[num];
Console.WriteLine("массив; ");

void Mas(int num)
{
    for(int i = 0; i < num; i++)
    {
        array[i] = Math.Round(new Random().NextDouble(),2)+new Random().Next(1,100);
        Console.WriteLine(array[i]);
    }
}
double Raz(double[]array)
{
    double min = array[0];
    double max = array[0];
    int i = 1;

    while(i < array.Length)
    {
        if(max < array[i])
        {
            max = array[i];
        }
        if(min > array[i])
        {
            min = array[i];
        }
        i = i + 1;
    }
    return max - min;
}
Mas(num);

Console.Write($"        Разница  =>  {Raz(array)} ");