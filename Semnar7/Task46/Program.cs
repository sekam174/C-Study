// задайте двумерный массив размером M x N
// заполненный случайными целыми числами

// m = 3, n = 4
//  1 4 8 19
//  5 6 33 2
//  77 3 8 1

// (int[,]array = new int[3,4])
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int colomns = Convert.ToInt32(Console.ReadLine());

int[,]matrix = new int[rows,colomns];

void Array()  //метод заполняет массив
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray() //метод выводит массив
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j <matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}
Array();
PrintArray();