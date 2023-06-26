// Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц
// например, даны две матрицы:
// 2 4  |  3 4 
// 3 2  |  3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,]array1 = new int[2,2];
{
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i,j] = new Random().Next(0,10);
            Console.Write(array1[i,j]+" ");
        }
        Console.WriteLine();
    }
    
}
Console.WriteLine("_____________");

int[,]array2 = new int[2,2];
{
    for(int i = 0; i < array2.GetLength(0); i++)
    {
        for(int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i,j] = new Random().Next(0,10);
            Console.Write(array2[i,j]+" ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("_____________");

int[,]array3 = new int[2,2];
{
    for(int i = 0; i < array3.GetLength(0); i++)
    {
        for(int j = 0; j < array3.GetLength(1); j++)
        {
            int sum = 0;
            for(int z = 0; z < array1.GetLength(1); z++)
            {
                sum += array1[i,z] * array2[z,j];
            }
            Console.Write((array3[i,j] = sum)+" ");
        }
        Console.WriteLine();
    }
}