// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input x:");

double x = double.Parse(Console.ReadLine());

double y = 0;
double p = 1;
int i = 10;

while(i > 0)
{
    y = y + i * p;
    p = p * x;
    i--;
}

Console.WriteLine(y);