// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void FillArray(int[] array)
{
    for(int i= 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] array)
{
    int length = array.Length;
    for(int i=0; i < length - 1; i++) Console.Write($"{array[i]}, ");
    Console.Write(array[length - 1]);
    Console.WriteLine();
}
int CountPositiv(int[] array)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i]>0) count++;
    }
    return count;
}
try
{
    Console.WriteLine("Введите количество чисел:");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[M];
    Console.WriteLine("Введите числа:");
    FillArray(numbers);
    PrintArray(numbers);
    int N = CountPositiv(numbers);
    Console.WriteLine("Количество положительных чисел равно: " + N);
}
catch
{
    Console.WriteLine("Вводите только целые числа");
}