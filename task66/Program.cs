//Задайте значения M и N. Напишите программу, которая
//найдёт сумму натуральных элементов в промежутке от M до N.


int n = Prompt("Введите первое число");
int m = Prompt("Введите второе число");

if (n > m)
{
  Console.WriteLine("Неверные данные");
}

else if (n == m) {
  Console.WriteLine(0);
}
else {
  Console.WriteLine(sumNumbers (n, m));
}

int sumNumbers (int a, int b)
{
  if (a <= b) return a + sumNumbers(a+1, b);
  else return 0;
}

int Prompt (string message) // метод для подсказки в консоль и ввода данных
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine());
  return number;
}
