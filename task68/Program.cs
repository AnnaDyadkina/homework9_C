//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int m = Prompt("Введите первое число");;
int n = Prompt("Введите второе число");;

if (m >= 0 && n >= 0)
{
  Console.WriteLine(A(m, n));
}
else
{
  Console.WriteLine("Ошибка");
}

int A (int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((n == 0) && (m > 0))
      return A(m - 1, 1);
  else
    //if ((n > 0) && (m > 0))
      return A(m - 1, A(m, n - 1));
}

int Prompt (string message) // метод для подсказки в консоль и ввода данных
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine());
  return number;
}
