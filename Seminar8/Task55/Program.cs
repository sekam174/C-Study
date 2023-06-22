// Задайте двумерный массив. напишите программу
// которая заменяет строки на столбцы,вслучае если это
// невозможно, прога выводит меседж для пользователя

Console.WriteLine("Введите количество строчек");
int rows = Convert.ToInt32(Console.ReadLine());

int[,]array = new int[rows,rows];
int[,]array2 = new int[array.GetLength(0),array.GetLength(1)];

void GetArray()
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}
void PrintArray(int[,]result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write(result[i,j]+" ");
        }
        Console.WriteLine();
    }
}
void FillNewArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[j,i] = array[i,j];
        }
    }
}
GetArray();
PrintArray(array);
FillNewArray();
Console.WriteLine();
PrintArray(array2);
