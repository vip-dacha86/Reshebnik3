//Напишите программу которая принимает на в вход координаты точки (X и y),причем x≠0 и y≠0 и выдает номер четверти 
//плоскости в которой эта точка находится.
Console.Write("Введите X: ");
int x =int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int y =int.Parse(Console.ReadLine());
if (x > 0 && y > 0){
    Console.WriteLine("1");
}else 
if (x < 0 && y >0){
    Console.WriteLine("2");
}else
if (x < 0 && y < 0){
    Console.WriteLine("3");
}else
if (x > 0 || y < 0){
    Console.WriteLine("4");
}else
if (x == 0|| y == 0){
    Console.WriteLine("На оси");
}
  

