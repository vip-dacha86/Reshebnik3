﻿ string Method4(int count,string text)
 {
     string result = String.Empty;
     for (int i = 0; i< count ; i ++)
     {
         result = result + text;
     }
 return result;
 }
string res = Method4 (10," Z ");
// Console.WriteLine(res);

for (int i =2; i <= 10; i ++)
{
      for (int j = 2; j <= 10; i ++)
    {
        Console.WriteLine($"{i} * {j}={i * j}");
    }
}
Console.WriteLine();