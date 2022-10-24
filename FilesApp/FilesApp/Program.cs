using System.Numerics;
using System.Reflection.PortableExecutable;

void Hello(string s)
{
    Console.WriteLine(s);
    //s = ""
}

int Sum(int x, int y)
{
    return x + y;    
}

void Swap(ref int x, ref int y)
{
    var t = x;
    x = y;
    y = t;
}

int ArrSum(int[] mas)
{
    int s = 0;
    mas[1] = 100;
    for (int i = 0; i < mas.Length; i++)
        s += mas[i];
    return s;
}


void GetInt(out int k)
{
    Random r = new Random();    

    k = r.Next(100);

}


using (StreamWriter writer = new StreamWriter(@"d:\Temp\output.txt", true))
{
    char ch = '\0';
    writer.WriteLine("My text 2!");
    writer.Close();
}

using (StreamReader reader = new StreamReader("input.txt"))
{
    string str;

    //while (!reader.EndOfStream)
    //{

    //    str = reader.ReadLine();

    //    Console.WriteLine(str);

    //}

    str = reader.ReadToEnd();
    //Console.WriteLine(str);

    int k = 0;
    foreach(string s in str.Split('\n'))
    {
        Console.WriteLine($"{k++} - {s}");

    }

}


int[,] matr;

using (StreamReader reader = new StreamReader("inMatr.txt"))
{
    var mn = reader.ReadLine().Split(' ');
    int m = int.Parse(mn[0]);
    int n = int.Parse(mn[1]);

    matr = new int[m, n];

    for(int i=0; i<m; i++)
    {
        var row = reader.ReadLine().Split(' ');
        for(int j=0; j < n ; j++)
            matr[i,j] = int.Parse(row[j]);
    }
}


for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
        Console.Write($"{matr[i, j],3} ");
    Console.WriteLine();
}



//int a = 5, b = 6;

//Console.WriteLine(Sum(a, b));

//int m;

//GetInt(out m); 

//Console.WriteLine($"m = {m}");



//Swap(ref a, ref b);
//Console.WriteLine($"a = {a}  b = {b}");


//Hello("Hello, World!");

//Hello("Hello 2!");

//Hello("Some text");

//string s = "Text 1";

//Hello(s);

//Console.WriteLine(s);


//int[] arr = { 1, 2, 3, 4, 5, 6 };

//Console.WriteLine(ArrSum(arr));

//foreach(int k in arr)
//    Console.WriteLine(k);
