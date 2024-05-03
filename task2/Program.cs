// создать массив и заполнить его числами от 1 до N;

int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < n)
{
    arr[i] = i + 1;
    Console.Write($"{arr[i]} ");
    i = i + 1;
}