using System.Diagnostics;
// Разработать  эффективный способ нахождения максимальнойсуммы трёх последовательных натуральных чисел массива случайных чисел
int GetNumber(string message)
{
    {
        int result;
        while (true)
        {
            Console.WriteLine(message);
            if (int.TryParse(Console.ReadLine(), out result))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ввели некорректное число, повторите ввод");
            }
        }
        return result;
    }
}
int arraySize = GetNumber($"Введите число, которое определит длину массива:");
//int m = GetNumber ($"Введите сколько чисел в сумме:")
Console.WriteLine($"Размерность массива {arraySize}");
// Метод для заполнения массива случайными  числами от 1 до 10 
int[] GetArray(int number)
{
    int[] matrix = new int[number];
    Random rnd = new Random();

    for (int i = 0; i < number; i++)
    {
        matrix[i] = rnd.Next(1, 10);
    }

    return matrix;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.Write($"{arr[i]}");
        }

        //Console.WriteLine();
    }
}

int[] newArray = GetArray(arraySize);
Console.WriteLine($"Массив для  подсчёта количества чётных чисел: ");
PrintArray(newArray);
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", newArray)}]");
// метод определения  максимальной суммы
Stopwatch sw = new();
sw.Start();
int m = 3;
int max = 0;

for (int i = 0; i < newArray.Length - m; i++)
{
    int t = 0;
    for (int j = i; j < i + m; j++)
    {
        t = t + newArray[j];
    }
    if (t > max) max = t;
}
sw.Stop();
Console.Write(max);
Console.WriteLine();
Console.WriteLine($"time = {sw.ElapsedMilliseconds}");


Stopwatch sw1 = new();
sw1.Start();
int max1 = 0;

for (int j = 0; j < m; j++) max1 += newArray[j];
int t1 = max1;
for (int i = 1; i < newArray.Length - m; i++)
{
    t1 = t1 - newArray[i - 1] + newArray[i + (m - 1)];
    if (t1 > max1) max1 = t1;
}
sw1.Stop();
Console.Write(max1);
Console.WriteLine();
Console.WriteLine($"time = {sw1.ElapsedMilliseconds}");