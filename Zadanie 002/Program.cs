Console.WriteLine("Введи свое первое число - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи свое второе число - ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
Console.WriteLine($"Большее {a} меньшее {b}");
}
if (a < b)
{
Console.WriteLine($"Меньшее {a} Большее {b}");
}