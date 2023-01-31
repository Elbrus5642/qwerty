// Разработать  эффективный способ нахождения максимальнойсуммы трёх последовательных натуральных чисел массива случайных чисел
int GetArrayDimention(string message)
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
int arraySize = GetArrayDimention($"Введите число, которое определит длину массива:");
Console.WriteLine($"Размерность массива {arraySize}");
// Метод для заполнения массива случайными 3-х значными числами (int GetArrayNumbers (int number) визуализация  массива 
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
int[] newMatrix = GetArray(arraySize);
Console.WriteLine($"Массив для  подсчёта количества чётных чисел: ");
PrintArray(newMatrix);
