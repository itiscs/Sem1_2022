int N = 20;
int[] arr = GenerateMas(N);
PrintMas(arr);

//PrintPositMass(arr, 0);

MergeSort(arr, 0, arr.Length - 1);

//BubbleSort(arr);

PrintMas(arr);

//Console.WriteLine(FindIntRec(arr, -83, 0, N - 1));

//Console.WriteLine(MaxMass(arr, N - 1));




bool FindInt(int[] mas, int x, int a, int b)
{
    while(a <= b)
    {
        int c = (a + b) / 2;
        if (mas[c] == x)
            return true;
        if (mas[c] < x)
            a = c + 1;
        else
            b = c - 1;
        Console.WriteLine($"{a}  {b}");
    }
    return false;   
}

bool FindIntRec(int[] mas, int x, int a, int b)
{
    int c = (a + b) / 2;
    if (mas[c] == x)
        return true;
    if (a > b)
        return false;

    if (mas[c] < x)
       return FindIntRec(mas, x, c + 1, b);

    return FindIntRec(mas, x, a, c - 1);

}


int SumMass(int[] arr, int k)
{
    if (k == 0)
        return arr[0];
    
    return arr[k] + SumMass(arr, k - 1);
}

int MaxMass(int[] arr, int k)
{
    if (k == 0)
        return arr[0];

    var oldMax = MaxMass(arr, k);
    return (oldMax < arr[k]) ? arr[k] : oldMax;
}



void PrintPositMass(int[] arr, int k)
{
    if (k >= arr.Length)
        return;

    PrintPositMass(arr, k + 1);

    if (arr[k] > 0)
        Console.Write($"{arr[k]} ");
}






int[] GenerateMas(int n)
{
    Random r = new Random();
    int[] mas = new int[n];
    for (int i = 0; i < n; i++)
        mas[i] = r.Next(-100,100);

    return mas; 
}

void PrintMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
        Console.Write($"{mas[i]} ");
    Console.WriteLine();
}


int GetMaxInd(int[] mas, int n)
{
    int iMax = 0;
    for(int i = 1; i < n; i++)
        if (mas[i] > mas[iMax])
            iMax = i;
    return iMax;
}


void BubbleSort(int[] mas)
{
    int n = mas.Length;
    //for(int k = n - 1; k > 0; k--)
    //    for(int i = 0; i < k; i++)
    //        if(mas[i] > mas[i+1])
    //        {
    //            var t = mas[i];
    //            mas[i] = mas[i + 1];
    //            mas[i + 1] = t;
    //        }
    bool fl = true;
    while(fl)
    {
        fl = false;
        for (int i = 0; i < n - 1; i++)
            if (mas[i] > mas[i + 1])
            {
                var t = mas[i];
                mas[i] = mas[i + 1];
                mas[i + 1] = t;
                fl = true;
            }
    }
}


void MergeSort(int[] arr, int a, int b)
{
    Console.WriteLine($"({a},{b})");
    if (b - a < 1)
        return;

    int c = (a + b) / 2;

    MergeSort(arr, a, c);
    MergeSort(arr, c + 1, b);

    int[] mergeArr = new int[b - a + 1];

    int i = a, j = c + 1;
    for(int k = 0; k < mergeArr.Length; k++)
    {
        if (i > c)            //закончился первый массив
            mergeArr[k] = arr[j++];
        else if (j > b)       //закончился второй массив
            mergeArr[k] = arr[i++];
        else if (arr[i] < arr[j])
            mergeArr[k] = arr[i++];
        else
            mergeArr[k] = arr[j++];
    }

    i = a;
    for (int k = 0; k < mergeArr.Length; k++)
        arr[i++] = mergeArr[k];
}

