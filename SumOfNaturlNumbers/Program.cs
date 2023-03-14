static int SumOfNaturalNumer(int input)
{
    // stopping condition
    if(input <= 1)
        return input;

    return input + SumOfNaturalNumer(input - 1);
}

int inputElement = 100;
Console.WriteLine(SumOfNaturalNumer(inputElement));
Console.ReadLine();