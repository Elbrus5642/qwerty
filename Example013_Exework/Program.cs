// Тренировка:  сортировка массива выбором 
int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int maxiCooper = i;
        for (int j = i + 1; j < arr.Length; j++)
        { 
            if (arr[j] > arr[maxiCooper]) maxiCooper = j;

            int tempElement = arr[i];
            arr[i] = arr[maxiCooper];
            arr[maxiCooper] = tempElement;
        }

    }

}



    void PrintArray(int[] arraySort)
{
    int count = arraySort.Length;
    for (int ind = 0; ind < count; ind++)
    {
        Console.Write($"{arraySort[ind]} ");
    }

}


SelectionSort(array);
PrintArray(array);