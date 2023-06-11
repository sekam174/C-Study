// задайте массив из 123 случайных чисел.
// найдите количество элементов массива,
// значение которых лежат в отрезке [10, 99]
// пример для массива из 5, не из 123 элементов
// в своём рещении сделайте для 123

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]    -> 0
// [10, 11, 12, 13, 14] -> 5

void FillArray(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 201);
        index++;
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
        if((collection[index] > 9) && (collection[index] < 100))
        {
            num = num + 1;
        }
        index++;
    }
    return num;
}
int[]array = new int[5];

FillArray(array);
PrintArray(array);

Console.WriteLine();

Console.WriteLine(IndexOf(array));