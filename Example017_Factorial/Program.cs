// Вычислить факториал числа N: n!
//int n = 6;
double Factorial(int n)
{
    if (n == 1  || n == 0)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
//Console.WriteLine($"{n} ! = {Factorial(n)}");
