﻿// Задача 3. Дано N гирь с разным весом в случайном порядке. Определить вес самой тяжелой гири. 
int n = 5;
int[] array = { 2, 4, 7, 3, 9 };
int i = 0;
int max = array[0];

while (i < n)
{
  if (array[i] > max)
  {
    max = array[i];
  }
  i = i + 1;
}
System.Console.WriteLine(max);

max = array[0];
for (int j = 0; j < n; j++)
{
  if (array[j] > max)
  {
    max = array[j];
  }
}
System.Console.WriteLine(max);

max = array[0];
foreach (int e in array)
{
  if (e > max)
    max = e;
}
System.Console.WriteLine(max);