// o -  notation
/*int[] array = new int[5];
int n  =  5;
Console.WriteLine($"Введите подряд пять чисел");
for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine(array[3]);*/
//[4,5,3,1,2]
/*int [] array1 = {4,5,3,1,2};
int m = 5; 
Console.WriteLine($"Массив для вычисления суммы элементов:");
Console.WriteLine("[" + string.Join(", ", array1) + "]");
int summ = 0;
for (int i = 0; i < m; i++)
{
    summ += array1[i];
}
Console.WriteLine($"Сумма элементов:");
Console.WriteLine($"{summ}");*/
/*
Console.WriteLine($"Введите  число для расчёта таблицы умножения:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int multi = 0;
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        multi = i * j;
        Console.Write($"{multi}");
        Console.Write("\t");
    }
    Console.WriteLine();
}*/

Console.WriteLine($"Введите  число для расчёта таблицы умножения:");
int n = Convert.ToInt32(Console.ReadLine());
int [ , ] matrix = new int[n,n]; 
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i,j] = (i + 1)  * (j + 1);
        matrix[j,i] = (i + 1)  * (j + 1);
        //Console.Write($"{matrix[i,j]}");
        //Console.Write(" ");
        //Console.Write("\t");
    }
   // Console.WriteLine($"Матрица заполняется {i}");
    Console.WriteLine();
}

for (int i = 0; i <n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matrix[i,j]}");
        Console.Write("\t");
    }
     Console.WriteLine();
}
