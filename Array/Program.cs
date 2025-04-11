var arr1 = new int[] { 1, 2, 3, 4 };
var arr2 = new int[] { 2, 3, 5, 7 };

int[] result = new int[arr1.Length + arr2.Length];

int index1 = 0;
int index2 = 0;


for (int i = 0; i < result.Length; i++)
{
    if (arr1.Length == index1 || arr1[index1] > arr2[index2])
    {
        result[i] = arr2[index2];
        index2++;
    }
    else
    {
        result[i] = arr1[index1];
        index1++;
    }
    Console.WriteLine(result[i]);
}
