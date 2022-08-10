// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numString = Convert.ToString(num);
Console.WriteLine("Вторая цифра - " + numString[1]);
