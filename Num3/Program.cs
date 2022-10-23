/*Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/


int[] InitArray(int length)
{
    int [] resultArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(0,100);
    }
return resultArray;
}
    void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int GetNumber(string message)
{
Console.WriteLine(message);
int result = int.Parse(Console.ReadLine());
return result;
}
(int, int ) GetItog(int[] array)
{
int maxArray = 0;
int minArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (maxArray < array[i]) 
        {
         maxArray = array[i];
        }
        if (minArray > array[i]) 
        {
         minArray = array[i];
        }
    }
    return (maxArray, minArray);
}

int length = GetNumber("Введите размер массива");
int[] arr = InitArray(length);
PrintArray(arr);
(int maxArray, int minArray) = GetItog(arr);
Console.WriteLine($"Разница = {maxArray - minArray}");