// int a = int.Parse(Console.ReadLine());
//             int s = 0;
//             while (a > 0)
//             {

//                 s = s + a % 10;
//                 a = a /10 ;

//             }
//  Console.WriteLine(s);
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int SumDigit(int numDigit);
// {
//     int count = 0;
//     while (numDigit > 0)
//     {
//         numDigit = Math.Abs(numDigit);
//         //count = count + numDigit % 10;
//         numDigit = numDigit / 10;
//         
//     }
//     return count;
// }
// int sumDigit = SumDigit(num);
// Console.WriteLine($"Сумма цыфр в числе = {sumDigit}");
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigit(int numDigit)
{
    numDigit = Math.Abs(numDigit);
    int count = 0;
    while (numDigit > 0)
    {
        count = count + numDigit % 10;
        numDigit = numDigit / 10;
        
    }
    return count > 0 ? count : 1;
}
int sumDigit = SumDigit(num);
Console.WriteLine($"Количество цифр в числе = {sumDigit}");