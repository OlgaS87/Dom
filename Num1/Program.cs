/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите массив: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

NumArray(array);
Console.WriteLine(" ");
PrintArray(array);
int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    if (count % 10 == 1)
    {
Console.WriteLine($"{array.Length}, {count} четные");
    }
void NumArray(int[] aray)
{
    for (int i = 0; i < array.Length ; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
Console.WriteLine();
}
Console.WriteLine($" -> {count}");

