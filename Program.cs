//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.
/*
int [] CreateArray(int size, int min, int max)
{
    int []array=new int[size];
    for(int i=0; i<size; i++)
    {
        array[i]= new Random().Next(min, max);
     }
    return array;
}

void ShowArray(int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}

int EvenNumb(int [] array)
{
    int evens=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0)
            evens++;
    }
    return evens;
}
Console.WriteLine("Input length array: ");
int size = Convert.ToInt32(Console.ReadLine());
int min =100;
int max=1000;  
int [] array = CreateArray(size, min, max);

ShowArray(array);

Console.WriteLine($"The number of even numbers in the array is  : {EvenNumb(array)}");
*/

//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.WriteLine("Input length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int min =-100;
int max=100;  
int [] array = CreateArray(size, min, max);

ShowArray(array);

int [] CreateArray(int size, int min, int max)
{
    int []array=new int[size];
    for(int i=0; i<size; i++)
    {
        array[i]= new Random().Next(min, max);
    }
    return array;
}

void ShowArray(int [] array){
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}

int Summ(int [] array)
{
    int summ=0;
    for (int i=0; i<array.Length; i++)
    {
        if (i%2>0)
           summ+= array[i];
    }
    return summ;
}

Console.WriteLine($"The sum of the numbers in odd positions: {Summ(array)}");
*/

//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
/*
Console.WriteLine("Input length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int min =-100;
int max=100;  
int [] array = CreateArray(size, min, max);

ShowArray(array);

int [] CreateArray(int size, int min, int max)
{
    int []array=new int[size];
    for(int i=0; i<size; i++)
    {
        array[i]= new Random().Next(min, max);
    }
    return array;
}

void ShowArray(int [] array){
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}

int Dec(int [] array)
{
    int dec=0;
    int min = array[0];
    int max=array[0];
    for (int i=1; i<array.Length; i++)
    {
        if (min>array[i])
           min= array[i];
        if (max<array[i])
            max=array[i];
    }
        dec=max-min;    
    return dec;
}

Console.WriteLine($"Difference the max and min elements of the array is: {Dec(array)}");
*/