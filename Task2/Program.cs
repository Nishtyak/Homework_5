// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = EnterNumber("Введите размер массива: ");
int min = EnterNumber("Введите минимальное число: ");
int max = EnterNumber("Введите максимальное число: ") + 1;
int[] array = FillArray(size, min, max);
PrintArray(array);
UnevenSum(array);

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

int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(min, max);
    }
    return arr;
}

void UnevenSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
}