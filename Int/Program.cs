int first = 50;
int second = 110;
int third = 1500;

// int[] result = new int[3];

// if (first > second)
// {
//     if (first > third)
//     {
//         Console.WriteLine($"First is the largest: {first}");
//     }
//     result[0] = first;
// }
// if (second > first)
// {
//     if (second > third)
//     {
//         Console.WriteLine($"Second is the largest: {second}");
//     }
//     result[1] = second;
// }
// if (third > first)
// {
//     if (third > second)
//     {
//         Console.WriteLine($"Third is the largest: {third}");
//     }
//     result[2] = third;
// }

int max = first;
if (max < second)
{
    max = second;
}
if (second < third)
{
    max = third;
}
// Console.WriteLine($"Sorted from lowest to highest: {result[0]}, {result[1]}, {result[2]}");
// Console.WriteLine($"Sorted from highest to lowest: {result[2]}, {result[1]}, {result[0]}");

System.Console.WriteLine(max);