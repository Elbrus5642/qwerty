// Функция получения чисел Фибоначчи  -  рекурсивная функция, поскольку каждое следующее число задаётся суммой двух предыдущих, числа Фибоначчи 1, 1, 2, 3, 5, 8, 13, 21, 34 ...
double Fibonacci(int n)
{
    if (n == 1 || n == 2)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
   }

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
