/*
 * Check if the given string is palindrome 
 * 
 */


static bool IsPalindrome(string input)
{
    // base case
    if (input.Length == 0 || input.Length == 1)
        return true;

    if (input[0] == input[input.Length - 1])
    {
        return IsPalindrome(input.Substring(1, input.Length-2)) ;
    }
    return false;
}

string element = "MnM";
Console.WriteLine(IsPalindrome(element));
Console.ReadLine();