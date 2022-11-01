int N = 20;
int[] arr = GenerateMas(N);
PrintMas(arr);

BubbleSort(arr);

PrintMas(arr);


int[] GenerateMas(int n)
{
    Random r = new Random();
    int[] mas = new int[n];
    for(int i = 0; i < n; i++)
        mas[i] = r.Next(-100,100);

    return mas; 
}

void PrintMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
        Console.Write($"{mas[i]} ");
    Console.WriteLine();
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
            if (mas[i] < mas[i + 1])
            {
                var t = mas[i];
                mas[i] = mas[i + 1];
                mas[i + 1] = t;
                fl = true;
            }
    }
    

}
