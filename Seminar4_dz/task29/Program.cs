// напишите программу, которая задаёт
// массив из 8 элеменов и выводит их на экран

// 1, 2, 5, 7, 13 -> [1, 3, 5, 7, 13]
// 6, 1, 33 -> [6, 1, 33]


void CreateArray()
{
    int[] arr = new int[8];
    int count = 0;

    Console.Write("[");

    while(count < arr.Length )
    {
        arr[count] = new Random().Next(1, 10);
        Console.Write($"{ arr[count]} ");
        count++;   
    } 
    Console.Write("]");
}
CreateArray();
