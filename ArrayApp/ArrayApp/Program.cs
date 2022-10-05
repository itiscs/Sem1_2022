int n = 10;
int[] arr = new int[n];

Random r = new Random();
//arr[5] = 20;

for (int i = 0; i < n; i++)
    arr[i] = r.Next(-100, 101);

//arr[0] = 20;

int sum = 0, kolPol = 0;
int max = int.MinValue;

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"a[{i}] = {arr[i]}");

    sum += arr[i];
    if (arr[i] > 0)
        kolPol++;
    if (arr[i] > max)
        max = arr[i];
}

Console.WriteLine($"sum = {sum}   kolPol = {kolPol}   max = {max}");

int[] mas = { -6, -3, -7, -65 };

bool fl = false;  // содержит ли массив отриц число
int  fl2 = 1;     // все числа в массиве отрицательные

for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine($"a[{i}] = {mas[i]}");
    if (mas[i] < 0)
        fl = true;
    if (mas[i] >= 0)
        fl2 = -1;

}

if (fl)
    Console.WriteLine("Есть отрицательное число");
else
    Console.WriteLine("Нет отрицательных чисел");

if (fl2 == 1)
    Console.WriteLine("все числа в массиве отрицательные");
else
    Console.WriteLine("не все числа в массиве отрицательные");





//Console.WriteLine("Hello, World!");
