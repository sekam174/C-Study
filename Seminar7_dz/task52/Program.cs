// Задайте двумерный массив из целых чисел
// Найдите среднее арифметическое элементов
// в каждом столбце

// 1 4 7 2
// 5 9 2 3 
// 8 4 2 4

// среднее арифметическое каждого столбца: 4,6;5,6;3,6;3

Console.WriteLine("Введите количество строк в массиве");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в массиве");
int columns = Convert.ToInt32(Console.ReadLine());

int[,]array = new int[rows,columns];

void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}
void SearchElArray()
{
    Console.Write($"Среднее арифметическое: ");
    int i,j;
    for( j = 0; j < columns; j++)
    {
        double sum = 0;
        for( i = 0; i < rows; i++)
        {
            sum = sum + array[i,j];
        }
        Console.Write($"{sum/(i) :F1}; ");
    }
}
FillArray();
PrintArray();
SearchElArray();