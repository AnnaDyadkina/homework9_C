 //Задайте значение N. Напишите программу, которая выведет все натуральные
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int n = Prompt("Введите число");

Console.WriteLine(showNumber(n));

string showNumber (int n)
{

  if (n >= 1) return $"{n} " + showNumber(n-1);
  else return String.Empty;
}

int Prompt (string message) // метод для подсказки в консоль и ввода данных
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine());
  return number;
}
