// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int enterNumber1;
Console.Write("Задайте длинну мвссива (N): ");
enterNumber1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"[");

int[] array = new int[enterNumber1];
for (int i = 0; i < enterNumber1; i++)
{
    array[i] = new Random().Next(enterNumber1+1);
    Console.Write(array[i] + "; ");
}

Console.Write($"{enterNumber1}] ");