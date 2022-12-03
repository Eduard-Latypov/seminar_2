// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да


System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
string result = (num % 7 == 0 && num % 23 == 0) ? "да" : "нет";
System.Console.WriteLine(result);







// if (num % 7 == 0)
// {
//     if (num % 23 == 0)
//     {
//         System.Console.WriteLine("да");
//     }
//     else
//         System.Console.WriteLine("нет");

// }

// else
//     System.Console.WriteLine("нет");



