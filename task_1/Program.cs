// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int num;

num = new Random().Next(100, 1000);
System.Console.WriteLine(num);
System.Console.WriteLine((num / 100) * 10 + (num % 10));
string chr = Convert.ToString(num);
System.Console.WriteLine(chr);
System.Console.WriteLine($"{chr[0]}{chr[^1]}");





