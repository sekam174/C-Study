// Напишите программу, которая найдёт току пересечения
// двух прямых заданных уравнениями Y = K1 * X + B1; Y = K2 * X + B2;
// значения B1, K1, B2, K2 задаются пользователем
 // B1 = 2, K1 = 5, B2 = 4, K2 = 9  -> (-0,5; -0,5)

 void Progs()
 {
 Console.Write("Введите число K1 = ");
 double K1 = Convert.ToInt32(Console.ReadLine());
 
 Console.Write("Введите число B1 = ");
 double B1 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите число K2 = ");
 double K2 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите число B2 = ");
 double B2 = Convert.ToInt32(Console.ReadLine());
 
 if(K1 != K2)
 {
    double X =-(B1 - B2) / (K1 - K2);
    double Y = K1 * X + B1;
    Console.WriteLine($"Пересечение в точке ({X}; {Y})");
 }
 else if(K1 == K2)
 {
    Console.WriteLine($"Параллельные прямые");
 }
 }
 Progs();
