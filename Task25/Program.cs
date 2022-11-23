// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Без использования функции Math.Pow.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int number1 = ReadInt("Введите первое число: ");
int number2 = ReadInt("Введите второе число: ");
int result = 1;

for (int i = 0; i < number2; i++)
{
    result *= number1;
}

Console.WriteLine($"Число {number1} в степени {number2} = {result}");


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

