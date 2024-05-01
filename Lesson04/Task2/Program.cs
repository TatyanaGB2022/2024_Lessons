﻿// Задача №2. Назовём число «интересным» если его сумма цифр чётная. Создать двумерный массив, состоящий из
// целых чисел. Вывести на экран «интересные» элементы массива

int[,] CreateMatrix(int rowCount, int columsCount)
{
  int[,] matrix = new int[rowCount, columsCount];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)//осуществит обращение к элементам одномерного массива
    {
      matrix[i, j] = rnd.Next(1, 1000);
    }
  }
  return matrix;
}

void ShowMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++) //обращаемся к количеству строк 
  {
    for (int j = 0; j < matrix.GetLength(1); j++)//обращаемся к количеству столбцов 
    {
      System.Console.Write($"{matrix[i, j]} "); //выводим матрицу на экран
    }
    System.Console.WriteLine();//перенос на новую строку
  }
}

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix (matrix);

foreach (int e in matrix)
{
  if (IsIntresting(e) == true) //проверяем каждый элемент на интересность
  {
    System.Console.WriteLine(e);
  }
}

bool IsIntresting(int value)
{
  int sumOfDigits = GetSumOfDigits(value);
  if (sumOfDigits % 2 == 0)
  {
    return true;
  }
  return false;

}
int GetSumOfDigits (int value)
{
  int sum =0;
  while(value > 0)
  {
    sum += value % 10;
    value /= 10;
  }
  return sum;
}