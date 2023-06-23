// задайте двумерный массив размером M x N,
// заполненный случайными вещественными числами
// M = 3, N = 4
// 0,5 7 -2 -0,2
//  1 -3  9 -9,8
// -7,1 8 4  7,8

Console.WriteLine("Введите количество строк массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива");
int colomns = Convert.ToInt32(Console.ReadLine());

double[,]array = new double[rows,colomns];

void Array()
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(-100,100)) / 10; 
        }
    }
}
void PrintArray()
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j  = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}
Array();
PrintArray();