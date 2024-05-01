// Задача №1 Создать двумерный массив с размерами 3 x 5, состоящий из целых чисел. Вывести его элементы на экран


int[,] CreateMatrix(int rowCount, int columsCount)
{
  int[,] matrix = new int[rowCount, columsCount];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)//осуществит обращение к элементам одномерного массива
    {
      matrix[i, j] = rnd.Next(1, 11);
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

int [,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);