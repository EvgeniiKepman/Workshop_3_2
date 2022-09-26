//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();

Console.WriteLine("Введите координаты x для a: ");
double xa = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты y для a: ");
double ya = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты z для a: ");
double za = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты x для b: ");
double xb = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты y для b: ");
double yb = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты z для b: ");
double zb = double.Parse(Console.ReadLine()!);

double d = Math.Sqrt (Math.Pow((xa-xb),2) + Math.Pow((ya-yb),2) + Math.Pow((za-zb),2));
Console.WriteLine($"Расстояние между точками a и b: {d}.");
