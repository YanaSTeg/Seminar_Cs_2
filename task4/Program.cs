// Напишите программу, которая принимает на вход число и проверяет, кратно оно одновременно 7 и 23
// 14 -> нет
// 46 -> нет
// 161 -> да

System.Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());
if (num1 % 7 == 0 && num1 % 23 == 0)
{
    System.Console.WriteLine("Число кратно");
}
else
{
    System.Console.WriteLine("Число не кратно");
}