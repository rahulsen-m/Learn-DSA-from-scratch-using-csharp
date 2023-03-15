#region Non optimized version
// this actually doing two recursive calls to get the result
static long Fibonacci(long n)
{
    // stopping condition 
    if (n == 0 || n == 1)
        return n;
    else
        // as per Fibonacci formula (F n = F n-1 +F n-2)
        return Fibonacci(n - 1) + Fibonacci(n - 2);
}

#endregion

#region Optimized version

// here we will be using array to store the fibonacci 

static long FibonacciOP(long n)
{
    // Declare an array to
    // store Fibonacci numbers.
    // 1 extra to handle
    // case, n = 0
    long[] r = new long[n + 1];

    r[0] = 0; r[1] = 1;
    for (int i = 2; i <= n; i++)
    {
        r[i] = r[i - 1] + r[i - 2];
    }
    return r[n];
}

#endregion

long element = 10;
Console.WriteLine(FibonacciOP(element));
Console.ReadLine();