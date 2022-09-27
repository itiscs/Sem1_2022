// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input k:");
int k = int.Parse(Console.ReadLine());

long x1, x2, x = 0;
x1 = 1;
x2 = 1;
for(int i = 3; i <= k; i++)
{
    x = x1 + x2;
    x2 = x1;
    x1 = x;
    Console.WriteLine($"{i} --- {x}");

}
//Console.WriteLine(x);
