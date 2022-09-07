// вариация задачи 41 - пользователь не задает сколько чисел он введет (то есть число M), 
// а подсчет количества чисел производится после того, как пользователь не ввел информацию и нажал Enter.

int[] FillArray()
{
    string[] temproryArray = new string[100];
    int count = 0;
    temproryArray[0] = Console.ReadLine();
    while(temproryArray[count] != "")
    {
        temproryArray[count + 1] = Console.ReadLine();
        count++;
    }
    int[] newArray = new int[count];
    for(int i=0; i < count; i++) newArray[i] = Convert.ToInt32(temproryArray[i]);
    return newArray;
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
    int countPos = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i]>0) countPos++;
    }
    return countPos;
}
try
{
    Console.WriteLine("Введите числа:");
    int[] numbers = FillArray();
    int N = CountPositiv(numbers);
    Console.WriteLine("Количество положительных чисел равно: " + N);
}
catch
{
    Console.WriteLine("Вводите только целые числа");
}