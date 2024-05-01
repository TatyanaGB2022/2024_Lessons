// Задача №1
// Создать массив и заполнить его целыми числами от 1 до N (N – произвольное натуральное число). Вывести элементы
// массива на экран.
// 
// Пример 1
// N = 4
// 1 2 3 4

// Пример 2
// Т = 6
// 1 2 3 4 5 6

int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < n) // или while (i < arr.Length)    Length в данном случае равен 10
{
  arr[i] = i + 1;
  // System.Console.Write(arr[i]);
  // System.Console.Write(" ");
  System.Console.Write($"{arr[i]} ");
  i = i + 1;
}

