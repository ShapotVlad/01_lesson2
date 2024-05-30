// определить  гирю вес которой наибольший из N гирь;

int n = 13; //количество гирь
int[] arr = new int[13] { 3, 6, 8, 42, 56, 85, 14, 25, 11, 52, 12, 48, 94 };//вес гирь
int max = arr[0];
int i = 0;

while (i < n) //цикл "пока"
{
    if (arr[i] > max) //через "если"
    {
        max = arr[i];
    }
    i = i + 1;
}
Console.WriteLine(max);

//второй  вариант

max = arr[0];
for (int j = 0; j < n; j++) //цикл "для"
{
    if (arr[j] > max)
    {
        max = arr[j];
    }
}
Console.WriteLine(max);


//третий вариант

max = arr[0];
foreach (int e in arr) // цикл"форэч"
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);
