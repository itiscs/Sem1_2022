int n = 6, m = 6;

int[,] matr = new int[n, m];

Random r = new Random();
//int[][] mmas = new int[n][];
//for(int i = 0; i < n; i++)
//    mmas[i] = new int[r.Next(8)];



for (int i = 0; i < n; i++)
    for(int j = 0; j < m; j++)
        matr[i, j] = r.Next(100);


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write($"{matr[i, j],4}");
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    int max = matr[i, 0];
    for (int j = 1; j < m; j++)
        if (max < matr[i, j])
            max = matr[i, j];
    Console.WriteLine($"{i} row - max = {max}");
}
for (int j = 0; j < m; j++)
{
    int min = matr[0, j];
    for (int i = 1; i < n; i++)
        if (min > matr[i, j])
            min = matr[i, j];
    Console.WriteLine($"{j} column - min = {min}");
}


for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < m; j++)
    {
        var t = matr[i, j];
        matr[i, j] = matr[j, i];
        matr[j, i] = t; 
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write($"{matr[i, j],4}");
    Console.WriteLine();
}


//Console.WriteLine(matr.Rank);
//Console.WriteLine(matr.GetLength(0));
//Console.WriteLine(matr.GetLength(1));





