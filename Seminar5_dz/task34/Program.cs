// задайте массив, заполненный случайными
// положительными трёхзначными числами.
// напишите программу, которая покажет
// количество чётных чисел в массве

// [345, 897, 568, 234] -> 2

void FillArray(int[]collection) // заполняем массив
{
    int length = collection.Length;
    int count = 0;

    while(count < length)
    {
        collection[count] = new Random().Next(100, 1000);
        count++;
    }
}
void PrintArray(int[]col)
{
    int count = col.Length;
    int position = 0;

    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[]collection)
{
    int num = 0;
    int count = collection.Length;
    int index = 0;

    while(index < count)
    {
        if(collection[index]%2 == 0)
        {
            num = num + 1;
        }
        index++;
    }
    return num;
}
int[]array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine(IndexOf(array));
