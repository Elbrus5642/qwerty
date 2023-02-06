
/*using System.Collections.Generic;
const int N = 1000; //размер матрицы
const int TRAEDS_NUMBER = 10; //количество потоков
int serialMultiRes = new int[N, N]; //Результат умножения матрицы на матрицу в одном потоке
int treadMultiRes = new int[N, N]; // Результат умножения матрицы на матрицу в много потоке

int[,] firstMatrix = MatrixGenerator(N, N);
int[,] secondMatrix = MatrixGenerator(N, N);
//Метод генерации матрицы
int[,] MatrixGenerator(int rows, int columns)
{
    Random _rand = new Random();
    int[,] res = new int[rows, columns];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = _rand.Next(-100, 100);
        }
    }
    return res;
}
SerialMatrixMul(firstMatrix, secondMatrix);
PrepareParallelMatrixMul();
//Метод перемножения двцх мартиц "а"  -  матрица справа, "в" - матрица слева
void SerialMatrixMul(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзвя переммножить такие марицы");
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                serialMultiRes[i, j] += a[i, k] * b[k, j]
            }
        }

    }
}
void PrepareParallelMatrixMul(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзвя переммножить такие марицы");
    int eachThreadCalc = N / TRAEDS_NUMBER;
    var threadsList = new List<Thread>(); //Коллекция потоков  -  список, или более удобноеб чем массив,  представление данных
    for (int i = 0; i < TRAEDS_NUMBER; i++)
    {
        int startPos = i * eachThreadCalc;
        int endPos = (i + 1) * eachThreadCalc;
        // если последний поток (с остаткими вычислений)
        if (i == TRAEDS_NUMBER - 1) endPos = N;
               threadsList.Add(new Thread() => PrepareParallelMatrixMul(a, b, startPos, endPos));
               //запуск каждого потока (взял задние из списка и побежал в магазин)
               threadsList[i].Start();    
    }
for (int i = 0; i < TREADS_NUMBERS; i++)
{
   //склеивает потоки с главным потоком
    threadsList[i].Join; 
}
}
void PrepareParallelMatrixMul(int a, int b, int startPos, int endPos)
{
    for (int i = startPos; i < endPos; i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                serialMultiRes[i, j] += a[i, k] * b[k, j]
            }
        }

    }
}*/
const int N = 1000; //размер матрицы
const int THREADS_NUMBER = 10;

int[,] serialMulRes = new int[N, N]; //результат выполнения умножения матриц в однопотоке
int[,] threadMulRes = new int[N, N]; //результат параллельного умножения матриц

int[,] firstMatrix = MatrixGenerator(N, N);
int[,] secondMatrix = MatrixGenerator(N, N);

SerialMatrixMul(firstMatrix, secondMatrix);
PrepareParallelMatrixMul(firstMatrix, secondMatrix);
Console.WriteLine(EqualityMatrix(serialMulRes, threadMulRes));



int[,] MatrixGenerator(int rows, int columns)
{
    Random _rand = new Random();
    int[,] res = new int[rows, columns];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = _rand.Next(-100, 100);
        }
    }
    return res;
}

void SerialMatrixMul(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы несогласованные матрицы");

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                serialMulRes[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}

void PrepareParallelMatrixMul(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы");
    int eachThreadCalc = N / THREADS_NUMBER;
    Thread[] arr = new Thread[2];
    var threadsList = new List<Thread>();
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        int startPos = i * eachThreadCalc;
        int endPos = (i + 1) * eachThreadCalc;
        //если последний поток
        if (i == THREADS_NUMBER - 1) endPos = N;
        threadsList.Add(new Thread(() => ParallelMatrixMul(a, b, startPos, endPos)));
        threadsList[i].Start();
    }
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        threadsList[i].Join();
    }
}

void ParallelMatrixMul(int[,] a, int[,] b, int startPos, int endPos)
{
    for (int i = startPos; i < endPos; i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                threadMulRes[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}

bool EqualityMatrix(int[,] fmatrix, int[,] smatrix)
{
    bool res = true;

    for (int i = 0; i < fmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < fmatrix.GetLength(1); j++)
        {
            res = res && (fmatrix[i, j] == smatrix[i, j]);
        }
    }

    return res;
}





