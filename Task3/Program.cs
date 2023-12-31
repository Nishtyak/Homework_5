﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int size = EnterNumberInt("Введите размер массива: ");
double min = EnterNumberDouble("Введите минимальное число: ");
double max = EnterNumberDouble("Введите максимальное число: ");
double[] array = FillArray(size, min, max);
PrintArray(array);
FindDiffMaxMin(array);

double EnterNumberDouble(string message)
{
    double num = 0;
    Console.Write(message);
    while(!double.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Введите число!");
    return num;
}

int EnterNumberInt(string message)
{
    int num = 0;
    Console.Write(message);
    while(!int.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Введите целое число!");
    return num;
}

void PrintArray (double[] arr)
{
    foreach (var el in arr)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine();
} 

double[] FillArray(int size, double min, double max)
{
    double[] arr = new double[size];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(min + ((max - min) * random.NextDouble()), 2);
        //arr[i] = Math.Round(random.NextDouble(), 2);
    }
    return arr;
}

double FindMin(double[] arr)
{
    double min = arr[0];
    foreach (var el in arr)
    {
        if(el < min) min = el;
    }
    return min;
}

double FindMax(double[] arr)
{
    double max = arr[0];
    foreach (var el in arr)
    {
        if(el > max) max = el;
    }
    return max;
}

void FindDiffMaxMin(double[] arr)
{
    double min = FindMin(arr);
    double max = FindMax(arr);
    double result = Math.Round(max - min, 2);
    Console.WriteLine($"{max} - {min} = {result}");
}