﻿Console.Clear();
Console.WriteLine("int number");
int a = Convert.ToInt32(Console.ReadLine());
int i = 2;

while (i <= a)
{
    Console.Write ($"{i} ");
    i += 2;
}