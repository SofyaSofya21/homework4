// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 
// Вывод сделать отдельным методом.
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]

int number = ReadInt("Введите число: ");

int[] arrayRandom = new int[number];

for (int i = 0; i < number; i++)
{
    arrayRandom[i] = new Random().Next(1,100);
}

PrintArray(arrayRandom);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray (int[] array)
{
    int i = 0;
    Console.Write($"{array.Length} -> [");
    for (i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[i]}]");
}