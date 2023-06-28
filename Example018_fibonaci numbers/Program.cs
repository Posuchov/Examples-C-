// числа Фибоначчи (Fibonacci)
// Fibonacci(1) = 1
// Fibonacci(2) = 1
// Fibonacci(n) = Fibonacci(n-1) + Fibonacci(n-2)
Console.Clear();

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2); // обязательно else return
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}