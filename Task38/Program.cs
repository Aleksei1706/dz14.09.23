/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

Console.Clear();

double[] RandomArray(int length, double min, double max)
{
    double[] array = new double[length];
    
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next() + rand.NextDouble();
    }
    return array;
}

double Result(double[] array)
{
    double result = 0;
    Array.Sort(array);
        if (array.Length > 0) {
            double min = array[0];
            double max = array[array.Length - 1];
            result = max - min;
        }
   return result;
}
double[] array = RandomArray(5, 1, 5);
Console.WriteLine(string.Join("; ", array));

double summ = Result(array);
Console.WriteLine($"Разница между максимальным и минимальным\n элементом: {summ}");