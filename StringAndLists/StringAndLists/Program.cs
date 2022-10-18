// See https://aka.ms/new-console-template for more information

using System.Text;

List<int> lst = new List<int>();

var n = 10;
for(int i=1; i <= n; i++)  
    lst.Add(i);

lst.Remove(lst[4]);
lst.Remove(1);
lst.Remove(2);

Console.WriteLine($"Contains 5 - {lst.Contains(18)}");

//for (int i = 0; i < lst.Count; i++)
//    Console.WriteLine($"lst[{i}] = {lst[i]}");

foreach(int k in lst)
{
    Console.WriteLine(k);
}

Console.WriteLine($"Count - {lst.Count} Capacity - {lst.Capacity}");

String str = "Hello world! abc gft";

Console.WriteLine(str);

//foreach(char c in str)
//    Console.WriteLine(c);

for(int i=0; i < str.Length; i++)
{
    Console.WriteLine(str[i]);
}

var splStr = str.Split(' ');

foreach(var word in splStr)
{
    Console.WriteLine(word);
}

//for (int i = 0; i < 6; i++)
//    str += $" {i}";

Console.WriteLine(str);

StringBuilder sb = new StringBuilder();
sb.Append(str);
for (int i = 0; i < 6; i++)
    sb.Append($" {i}");

Console.WriteLine(sb.ToString());



