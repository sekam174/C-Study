// задайте двумерный массив размером m на n,
// каждый элемент в массиве находится по формуле
// A mn = m+n. выведите полученный массив на экран

// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int rows = Convert.ToInt32(Console.ReadLine());
int colomns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows,colomns];

void Array()
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i + j;
        }
    }
}
void PrintArray()
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}
Array();
PrintArray();