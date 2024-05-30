// создать массив и заполнить его числами от 1 до N;

int n = 10; //создали переменную до которо числа заполнить
int[] arr = new int[n];// создали одномерный массив на n элементов
int i = 0; //создали начальную переменную


while (i < n) //создали цикл заполнения
{
    arr[i] = i + 1;
    Console.Write($"{arr[i]} ");
    i = i + 1;
}

Console.WriteLine();

// второй  вариант

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];// создали одномерный массив на n элементов
int j = 0; //создали начальную переменную

while (j < num) //создали цикл заполнения
{
    array[j] = j + 1;
    Console.Write($"{array[j]} ");
    j++;
}