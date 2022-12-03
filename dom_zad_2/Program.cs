// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
System.Console.WriteLine("Введите число");
string num = Console.ReadLine();
if (num.Length < 3)
    System.Console.WriteLine("третьей цифры нет");
else
{
    System.Console.WriteLine(Convert.ToInt32(num) / Convert.ToInt32(Math.Pow(10, num.Length - 3)) % 10);
}

// если длина числа больше 3-х, нам нужно обрезать число так, чтобы осталось 3 цифры, и команда     Convert.ToInt32(num) / Convert.ToInt32(Math.Pow(10, num.Length - 3)) выполняет эту задачу! В итоге на выходе получается тип (int), хотя в коде я в основном работаю с (string).

