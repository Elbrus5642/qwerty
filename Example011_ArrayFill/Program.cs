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

int IndexOf(int[] collection, int find)
{
    int count  =  collection.Length;
    int index = 0;
    int position  = -1;
    // Обратите внимание, что если такого элемента в массиве не существует, 
    //то выводится -1
    while (index < count)
    {
          if (collection[index] == find)
            {
               position = index;
               break;
            }
     index++;       
    } 
    return position;           
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 45);
Console.WriteLine(pos);
