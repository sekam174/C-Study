// задайте массив, заполненный случайными
// положительными трёхзначными числами.
// напишите программу, которая покажет
// количество чётных чисел в массве

// [345, 897, 568, 234] -> 2

int[]array = new int[4];

Console.WriteLine();
Console.Write("[");

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i]+", ");
}
Console.Write("]");

int num = 0;
int count = array.Length;
int index =0;

while(index < count)
{
    if(array[index] %2 == 0)
    {
        num = num + 1;
    }
    index++;
}
Console.WriteLine("  ->  " + num);

// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] %2 == 0)
//     {
//         num++;
//     }
// }
// Console.WriteLine("  ->  " + num);