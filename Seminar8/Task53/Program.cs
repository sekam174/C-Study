// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива

Console.WriteLine("Введите количество строчек");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,]array = new int[rows,columns];

void GetArray()
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
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
void ChangArray()
{
    int maxIndex = array.GetLength(0) -1; //индех последней строчки записыв.
    //                                      в переменную maxIndex
    for(int j = 0; j < array.GetLength(1); j++) //цикл проход. по столбцам
    {
        int temp = array[0,j];         //каждый элт 1ой стр.запис.в temp
        array[0,j] = array[maxIndex,j];//в 1ый элт запис.элт последн.строчки
        array[maxIndex,j] = temp;      //обращ.к последн.элту и запис.значен
    }                                  //котор.было в последней строке
}
GetArray();                            //array[0,j]-вся верхняя строчка
PrintArray();                          //int maxIndex-индех послед.строчки
ChangArray();
Console.WriteLine();
PrintArray();
