// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = ReadInt("Введите число: ");
int rest = number;
int sum = 0;

while(rest != 0)
{
    sum += rest%10;
    rest /= 10;
}

Console.WriteLine($"{number} -> {sum}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

