// пользователь вводит с клавы М чисел.
// посчитайте, сколько чисел больше 0 ввёл пользователь

// 0, 7, 8, -2, -2  -> 2
//-1, -7,  56, 89, 22 -> 3

// Понравилась Ваша фишка

int result = 0;
string exitSim = "$";

int Kol()
{
    Console.Write("Введите число; если хотите выйти, нажмите " + exitSim);
    string sim = Console.ReadLine();

    if(sim == exitSim)
    {
        return result;
    }
    int sum = Convert.ToInt32(sim);
    if(sum > 0)
    {
        result += 1;
    }
    Console.WriteLine($"{ result}");
    return Kol();
}
Kol();
