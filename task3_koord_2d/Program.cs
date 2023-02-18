// Напишите программу которая принимает на вхож координаты двух точек и находит расстояние между ними в 2D пространстве.
//A(3,6);B(2,1)->5,09   A(7,-5);B(1,-1)->7,21  
// sqrt((3-2))^2+(6-1)^2=5,09
//double S = Math.Sqrt(...)

Console.WriteLine("Введите x1: ");
double x1 =double.Parse(Console.ReadLine());
Console.WriteLine("Введите y1: ");
double y1 =double.Parse(Console.ReadLine());
Console.WriteLine("Введите x2: ");
double x2 =double.Parse(Console.ReadLine());
Console.WriteLine("Введите y2: ");
double y2 =double.Parse(Console.ReadLine());
double d =Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));//(x1-x2)*(x1-x2)
Console.WriteLine($"d={d:f3}");
