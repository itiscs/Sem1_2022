

int[] a = new int[] { -21, 16, 17, 22, 23, 24};
int[] b = new int[] { 6, 7, 18, 8, 10, 12};

var na = a.Length;
var nb = b.Length;
int[] c = new int[na + nb];
int i =0 , j = 0, k = 0;

while(i < na && j < nb)
{
    if (a[i] <= b[j])
        c[k++] = a[i++];
    else
        c[k++] = b[j++];        
}
if (i == na) // закончился массив a
    for (i = j; i < nb; i++)
        c[k++] = b[i];
else         // закончился массив b
    for (j = i; j < na; j++)
        c[k++] = a[j];


for(i = 0; i< c.Length; i++)
    Console.WriteLine(c[i]);





