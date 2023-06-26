// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = EnterNumber("Введите размер массива: ");
int[] array = FillArray(size);
PrintArray(array);
CountEven(array);

int EnterNumber(string message)
{
    int num = 0;
    Console.Write(message);
    while(!int.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Введите число!");
    return num;
}

void PrintArray (int[] arr)
{
    foreach (var el in arr)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine();
} 

int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000);
    }
    return arr;
}

void CountEven(int[] arr)
{
    int count = 0;
    foreach (var el in arr)
    {
        if(el % 2 == 0) count++;
    }
    Console.WriteLine($"Количество четных чисел: {count}");
}