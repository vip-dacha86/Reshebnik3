//Напишите программу которая по заданному номеру четверти показывает диапазон
//возможных координат точек в этой четверти (x и y)

Console.Write("Введите номер четверти ");
int quater = int.Parse(Console.ReadLine());

switch (quater)
 { 
    case1:
{
    Console.WriteLine("x>0 y>0");
    break;
}
case2:
{
    Console.WriteLine("x<0 y>0");
    break;
}
case3:
{
    Console.WriteLine("x<0 y<0");
    break;
}
case4:
{
    Console.WriteLine("x>0 y<0");
    break;
}
default:{
    Console.WriteLine("Введена неправильная четверть"());
    break;
}
}




