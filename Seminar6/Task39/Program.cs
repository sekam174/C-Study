// напишите программу, которая
// перевернёт одномерный массив
// (последний эл-т будет на первом месте,
// а первый на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [5 7 3 6]   -> [6 3 7 5]

int[]array = new int[] {1,2,3,4,5};

for(int i = 0; i < array.Length/2; i++)
{
    int temp = array[i];
    array[i] = array[array.Length -1 -i];
    array[array.Length -1 -i] = temp;
}
// for(int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i]+",");
// }

// Можно без использования второго цикла
// String.Join() -> заменяет цикл

Console.WriteLine(String.Join(",", array));