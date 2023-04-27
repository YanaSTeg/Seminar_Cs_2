// Напишите программу, которая выводит 3х значное число и удаляет вторую цифру этого числа

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
System.Console.WriteLine($"Трехзначное число {number}");
int ic = number/100;
int i = number % 10;
int result = ic * 10 + i;
System.Console.WriteLine($"{result}");