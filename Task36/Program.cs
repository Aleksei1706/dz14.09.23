/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

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
    for (int i = 1; i < array.Length; i +=2)
    {
        count = count + array[i];
    }
    return count;
}

int[] array = RandomArray(5, 1, 10);
Console.WriteLine(string.Join(", ", array));

int result = schet(array);
Console.WriteLine($"Сумма чисел на нечетных позициях: {result}");