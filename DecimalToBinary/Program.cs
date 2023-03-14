/*
 * Decimal to binary
 * Logic is like you need to get the modules of the number and keep adding the reminders
 * 233
 * 233 % 2 = 116 -- rem -> 1
 * 116 % 2 = 58 -- rem -> 0
 * 58 % 2 = 29 -- rem -> 0
 * and so on 
 * last 1 % 2 = 0 -- rem -> 1 , so when we will get 0 as a divided result then we need to stop
 * now return the reminder in order they pushed to the stack means last will be first to out
 * and- 11101001
 */

static string DecimalToBinary(int input, string result)
{
    if (input == 0)
        return result;

    result = input % 2 + result;
    return DecimalToBinary(input / 2, result);
}

int decimalNumber = 233;
Console.WriteLine(DecimalToBinary(decimalNumber, ""));
Console.Read();