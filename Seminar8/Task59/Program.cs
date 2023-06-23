// Задайте двумерный массив из целых чисел.
// напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элт массива

Console.WriteLine("Введите количество строчек");
int rows = Convert.ToInt32(Console.ReadLine());

int[,]array = new int[rows,rows];
int minVulue = int.MaxValue;

int minIndexRows = 0;
int minIndexColumns = 0;

void GetArray()
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
            if(array[i,j] < minVulue)
            {
                minVulue = array[i,j];
                minIndexRows = i;
                minIndexColumns = j;
            }
        }
    }
}
void PrintArray(int[,]result)
{
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write(result[i,j]+" ");
        }
        Console.WriteLine();
    }
}
void FillNewArray()
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(i != minIndexRows)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(j != minIndexColumns)
                {
                    Console.Write(array[i,j]);
                }
            }
        }
        Console.WriteLine();
    }
}
GetArray();
PrintArray(array);
Console.WriteLine();
FillNewArray();
Console.WriteLine($"Мин. знач.:{minVulue},индексы{minIndexRows},{minIndexColumns}");