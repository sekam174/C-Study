// напишите программу, которая                /|
// принимает на вход координаты              / | 
// двух точек и находит                     /  | 
// расстояние между ними                   /   |
// в 2D пространстве                    c /    | a 
//                                       /     |
// A(3, 6); B(2, 1) -> 5,09             /      |
// A(7,-5); B(1,-1) -> 7,21            /_______|      
//       /-------------\                    b               
// c = \/ (a*a) + (b*b)
//
// d = (X2 - X1)2 + (Y2 - Y1)2

Console.WriteLine("Введите число X1");
int X1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Y1");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число X2");
int X2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Y2");
int Y2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2));

Console.WriteLine(d);