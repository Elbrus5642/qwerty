//Console.WriteLine("");
/* Внимание  -  ещё одно определение массива: 
создай новый массив, в котором будет 10 элементов */ 
void FillArray (int[] collect)
{
    int length = collect.Length;
    int index = 0;
    while (index < length)
    {
        collect[index] = new Random().Next(1, 10);
        // index = index + 1;
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {   
        Console.WriteLine($"Значение текущего элемента массива {col[position]}");
        position++;  
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
