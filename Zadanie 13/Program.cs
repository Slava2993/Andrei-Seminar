//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
//Console.WriteLine("Введите трехзначное число."); - Для себя сделал
//int n = Convert.ToInt32(Console.ReadLine());  - Для себя сделал
int n = 24356;
if(n > 99)
{
    Console.WriteLine((n / 100) % 10);
}
else
Console.WriteLine("третьей цифры нет");
