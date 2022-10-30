//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Введите цифру дня недели.");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0 & number < 8){
if (number == 1) {
Console.WriteLine("Понедельник нет");
}
if (number == 2) {
Console.WriteLine("Вторник нет");
}
if (number == 3) {
Console.WriteLine("Среда нет");
}
if (number == 4) {
Console.WriteLine("Четверг нет");
}
if (number == 5) {
Console.WriteLine("Пятница нет");
}
if (number == 6) {
Console.WriteLine("Суббота Да");
}
if (number == 7){
Console.WriteLine("Воскресение Да");
}
}
else {Console.WriteLine("Ввели не то число))))");}