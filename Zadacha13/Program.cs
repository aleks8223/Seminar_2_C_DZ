// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Максимум 100000)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число ");
int number = Convert.ToInt32(Console.ReadLine()!);
string numbertext = Convert.ToString(number);
if(numbertext.Length >= 3 && numbertext.Length <= 6)
{
    Console.WriteLine($"Третья цифра введённого числа -> " + numbertext[2]);
}
else Console.WriteLine("-> третьей цифры нет");
