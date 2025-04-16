// 

int[] massiv = new int[0];

void add(int x)
{
    int[] newArr = new int[massiv.Length + 1]; // haytararum enq nor arr mi hatov mec
    for (int c = 0; c < massiv.Length; c++) // patchenum enq hin array nori mej
    {
        newArr[c] = massiv[c];

    }
    newArr[newArr.Length - 1] = x; // nor array i verjum avelacnum enq X -y
    massiv = newArr; // poxarinum enq hin array norov
}


//Stexic nerqev chkpnel

for (int i = 0; i < 100; i++)
{
    add(2 * i);
}

for (int i = 0; i < massiv.Length; i++)
{
    System.Console.WriteLine(massiv[i]);
}