// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] CreateRandomArray (int size, int minVal, int maxVal)   //  метод создания массива размером size со значениями от minVal до maxVal
{
    int [] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal+1);
    return newArray;
}


void ShowArray (int [] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i]+ " ");
        Console.WriteLine();
}

void Count (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0){
        count ++;
        }
    Console.WriteLine($"count of honest elements is {count}");
}

int sizeStart = new Random().Next(2, 100);
int minPossibleVal = 100;
int maxPossibleVal = 999;

int [] arrayStart = CreateRandomArray(sizeStart, minPossibleVal, maxPossibleVal); // создали рандомный массив
ShowArray(arrayStart); // продемонстрировали исходный массив
Count(arrayStart);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreateRandomArray (int size, int minVal, int maxVal)   //  метод создания массива размером size со значениями от minVal до maxVal
{
    int [] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal+1);
    return newArray;
}


void ShowArray (int [] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i]+ " ");
        Console.WriteLine();
}

void SummOdd (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
        {
        sum = sum + array[i];
        }
    Console.WriteLine($"sum of odd elements is {sum}");
}




int sizeStart = new Random().Next(2, 10);
int minPossibleVal = 1;
int maxPossibleVal = 999;

int [] arrayStart = CreateRandomArray(sizeStart, minPossibleVal, maxPossibleVal); // создали рандомный массив
ShowArray(arrayStart); // продемонстрировали исходный массив
SummOdd(arrayStart);

*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] CreateRandomArray (int size, int minVal, int maxVal)   //  метод создания массива размером size со значениями от minVal до maxVal
{
    double [] newArray = new double[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal+1) + new Random().NextDouble();
    return newArray;
}


void ShowArray (double [] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i]+ " ");
        Console.WriteLine();
}

void Razn (double [] array)
{
    double max = 0;
    double min = array[0];
    double razn = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];

        }
    razn = max - min;
     Console.WriteLine($"Minimum is {min}");
     Console.WriteLine($"Maximum is {max}");
    Console.WriteLine($"Difference between Min and Max Value is {razn}");
}




int sizeStart = 5;
int minPossibleVal = 1;
int maxPossibleVal = 99;

double [] arrayStart = CreateRandomArray(sizeStart, minPossibleVal, maxPossibleVal); // создали рандомный массив
ShowArray(arrayStart); // продемонстрировали исходный массив
Razn(arrayStart);