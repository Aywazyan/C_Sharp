int first = 5;
int second = 10;
int third = 15;

int[] result = new int[3];
bool isLargest = false;

if (first > second)
{
    if (first > third)
    {
        Console.WriteLine($"First is the largest: {first}");
    }
    result[0] = first;
}
if (second > first)
{
    if (second > third)
    {
        Console.WriteLine($"Second is the largest: {second}");
    }
    result[1] = second;
}
if (third > first)
{
    if (third > second)
    {
        Console.WriteLine($"Third is the largest: {third}");
    }
    result[2] = third;
}
Console.WriteLine($"Sorted from lowest to highest: {result[0]}, {result[1]}, {result[2]}");
Console.WriteLine($"Sorted from highest to lowest:{result[2]}, {result[1]}, {result[1]}");