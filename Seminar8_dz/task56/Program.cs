// Задайте прямоугольный двумерный массив. Напишите программу
// которая будет находить строку с наименьшей суммой эл-тов
// например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// номер строки с наименьшей суммой эл-тов; 1 строка

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество стобцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,]array = new int[rows,columns];

void GetArray()
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
        
    }
}
void PrintArray()
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}
void SumInRows()
{
    int[]sumInRows = new int[array.GetLength(0)];
    Console.Write("Суммы элементов в каждой строке: ");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sumInRows[i] += array[i,j]; 
        }
        Console.Write($"{sumInRows[i]} ");
    }
    Console.WriteLine();
    int minI = 0;
    for(int i = 0; i < sumInRows.Length; i++)
    {
        if(sumInRows[minI] > sumInRows[i])
        {
            minI = i;
        }
    }
    Console.Write($"Наименьшая сумма элементов: {sumInRows[minI]}");
    Console.WriteLine();
    Console.Write($"Номер строки с наименьшей суммой: {minI +1}");
}

GetArray();
PrintArray();
SumInRows();
