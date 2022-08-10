// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numString = Convert.ToString(num);

void CheckNumber(string numString)
{
    if (numString.Length > 2)
    {
        Console.WriteLine("Третья цифра - " + numString[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

CheckNumber(numString);
