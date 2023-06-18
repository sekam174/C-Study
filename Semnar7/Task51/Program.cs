// задайте двумерный массив. найдите сумму элементов
// находящихся на главнойдиагонали (0,0)(1,1) и т.д.
//  1 4 7 2 
//  5 9 2 3 
//  8 4 2 4
// сумма эл-тов главной диагонали: 1+9+2 = 12

int rows = Convert.ToInt32(Console.ReadLine());
int colomns = Convert.ToInt32(Console.ReadLine());

int[,]matrix = new int[rows,colomns];

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
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}
void SearchElementArray()
{
    int sum = 0;

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i==j)
            {
                sum = sum + matrix[i,j];
            }
        }
    }
    Console.WriteLine($"Сумма равна: {sum}");
}
Array();
PrintArray();
SearchElementArray();