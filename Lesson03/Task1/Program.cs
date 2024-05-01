// Вычислить значение формулы a*b/c+d,где a, b, c, d - некоторые целые числа. Решение оформить в виде функции

double ConculateFormula(int a, int b, int c, int d)
{
  double numerator = a * b;
  int denominator = c + d;
  double result = numerator / denominator;
  return result;
}

double result = ConculateFormula(1, 2, 3, 4);
System.Console.WriteLine(result);
