// Функция будет возвращать целое число значение факториал

int Fact(int n)
{
  if (n == 1 || n == 0)
  {
    return 1;
  }
  return n * Fact(n - 1);
}

System.Console.WriteLine(Fact(0));


//F11 шаг с заходом
//F10 шаг с обходом
//F5 продолжить 
