//создать массив  из 10 элементов,
//вывести четные числа на консоль

int n = 10;
int[] arr = { 34, 23, 56, 41, 44, 87, 95, 13, 14, 25 };
int i = 0;


while (i < n)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}
 //второй вариант
 
int[] array = new int[10] { 22, 29, 8, 5, 3, 54, 55, 58, 13, 31 };
int j = 0;

while (j < 10)
{
    if (array[j] % 2 == 0)
    {
        Console.Write($"{array[j]} ");
    }
    j = j + 1;
}

