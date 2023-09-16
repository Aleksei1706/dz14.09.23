/*
Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел 
в массиве.
[345, 897, 568, 234] -> 2
*/

using System.ComponentModel.DataAnnotations;

int[] RandomArray(int length, int min, int max)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int schet(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = RandomArray(10, 100, 1000);
Console.WriteLine(string.Join(", ", array));

int result = schet(array);
Console.WriteLine($"Четных чисел: {result}");
