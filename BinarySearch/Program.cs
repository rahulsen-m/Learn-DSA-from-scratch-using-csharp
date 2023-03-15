/*
 * Binary search
 */

static int BinarySearch(int[] a, int left, int right, int x)
{
    // check if two end crossed each other
    if (left > right)
        return -1;
    // find the mid
    int mid = (left + right) / 2;
    // check if find element and mid element are equal
    if (x == a[mid])
        return mid;

    // check if find element is grater then mid
    if (x < a[mid])
        return BinarySearch(a, left, mid - 1, x);

    // check if find element is less then the mid
    return BinarySearch(a, mid + 1, right, x);
}

int[] element = new int[] { -1,0,1,2,3,4,7,9,10,20 };
var result = BinarySearch(element, 0, 9, 10);
Console.WriteLine(result);
Console.Read();