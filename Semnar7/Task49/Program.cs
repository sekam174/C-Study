// задайте двумерный массив. найдите элементы у которых
// оба индекса чётные и замените эти эл-ты на их квадраты
// например изначально массив выглядел вот так

//  1 4 7 2
//  5 9 2 3 
//  8 4 2 4

int rows = Convert.ToInt32(Console.ReadLine());
int colomns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows,colomns];



void Array()
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
    }
}
void PrintArray()
{
    for(int i =0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}
// находит эл-т с чётными координатами и возводит в квадрат
void ChangArray()
{
    Console.WriteLine();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if((i%2==0) && (j%2==0))
            {
                matrix[i,j] = matrix[i,j] * matrix[i,j];
            }
        }
    }
}
Array();
PrintArray();
ChangArray();
PrintArray();