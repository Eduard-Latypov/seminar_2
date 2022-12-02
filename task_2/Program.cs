// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
System.Console.WriteLine("Введите числа");
System.Console.Write("Введите 1-ое число: ");
int num1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите 2-ое число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 % num2 == 0)
{
    System.Console.WriteLine("кратно!");
}
else
{
    System.Console.WriteLine($"Не кратно, остаток {num1 % num2}");
}

// string result = (num1 % num2 == 0) ? "кратно" : ($"не кратно, остаток {num1 % num2}");
// System.Console.WriteLine(result);



