﻿// Напишите программу которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N
// 5->1,4,9,16,25.      // 2->1,4/ 
Console.WriteLine("Введите число N: ");
int N =int.Parse(Console.ReadLine());
int[]result =new int[N];
for (int i =1;i<=N;i++)
result[i-1]=i*i;
for ( int i = 0; i < N; i ++)
Console.Write($"{result[i]} ");