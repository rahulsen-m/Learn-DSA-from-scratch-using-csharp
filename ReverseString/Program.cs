/*
 * Reverse the given string  
 * 
 * in this case we are taking the last first character and recursively call the function with remaining characters
 * in this example , input is hello
 * so first ReverseString("ello") + "H" -1
 * then it will again call the function recursively with ReverseString("llo") + "e" -2
 * then it will again call the function recursively with ReverseString("lo") + "l" -3
 * then it will again call the function recursively with ReverseString("o") + "l" -4
 * then it will again call the function recursively with ReverseString("") + "o" -5 // here we have reached the base case where string is empty
 * Now the call stack will start removing the results
 * o + " - 5
 * o + l -4
 * ol + l -3
 * oll + e -2
 * olle + H -1
  * 
 */



static string ReverseString(string s)
{
    // base case 
    if(string.IsNullOrEmpty(s))
        return s;

    return ReverseString(s.Substring(1)) + s[0];
}

string input = "RAhul";
Console.WriteLine(ReverseString(input));
Console.Read();