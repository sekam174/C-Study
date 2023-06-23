// Напишите программу, которая на вход принимает
// позиции эл-та в двумерном массиве и возвращает значение
// этого эл-та, или указ. что такого эл-та нет

// 2 4 7 4 
// 5 9 2 3 
// 8 4 2 4
// 17 - такого числа в массиве нет

Console.WriteLine("Введите количество строчек");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,]array = new int[rows,columns];

void SearchElArray()
{
    if(rows > array.GetLength(0) || columns > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"Знач.эл-та{rows}строки и {columns}столбца= {array[rows-1,columns-1]}");
    }
}
void Array()
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}
Array();
PrintArray();
SearchElArray();