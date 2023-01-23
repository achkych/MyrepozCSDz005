// методы: 1. генерирующие 2. аналитические 3. преобразующие.
/*
//1.Z Написать программу, которая определяет сумму отрицательных элементов в массиве
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
   int[] array = new int[size];
   
   for(int i = 0; i < size; i++)
   array[i] = new Random().Next(minValue, maxValue + 1);
   
   return array;
}

int GetSumOfNegatives(int[] array)
{
   int sum = 0;

   for(int i= 0; i < array.Length; i++)
      if(array[i] < 0) 
         sum += array[i];
   return sum;

}

void ShowArray(int[] array)
{
   for(int i = 0; i < array.Length; i++)
       Console.Write(array[i] + " ");

   Console.WriteLine();
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);

int result = GetSumOfNegatives(newArray);
Console.WriteLine("Sum Of Negatives in this array is" + result);
*/
/*
2z. Написать программу, заменяющую положительные элементы массива на отрицательные и наоборот.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
   int[] array = new int[size];
   
   for(int i = 0; i < size; i++)
   array[i] = new Random().Next(minValue, maxValue + 1);
   
   return array;
}


void ShowArray(int[] arr)
{
   for(int i = 0; i < arr.Length; i++)
       Console.Write(arr[i] + " ");

   Console.WriteLine();
}

int[] ConvertArray(int[] arr)
{
 for(int i = 0; i < arr.Length; i++)
  {  
  arr[i] = -arr[i];
  }
  return arr;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, min, max);
ShowArray(array);

int[] newArray = ConvertArray(array);
ShowArray(newArray);
*/
/*
//2z.Написать программу, определяющую, присутствует ли заданное число в массиве.
bool IsNumberInArray (int[] array, int numb)
{
    for (int i = 0; i < array.Length; i++)
         if(array[i] == numb) return true;
    return false;
}
*/
/* 3z.Задать массив из n элементов, определить кол-во элементов, принадлежащих отрезку [a,b].
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
   int[] array = new int[size];
   
   for(int i = 0; i < size; i++)
   array[i] = new Random().Next(minValue, maxValue + 1);
   
   return array;
}


void ShowArray(int[] arr)
{
   for(int i = 0; i < arr.Length; i++)
       Console.Write(arr[i] + " ");

   Console.WriteLine();
}

int Checking(int[] arr, int min, int max)
{ 
   int count = 0;

   for(int i = 0; i < arr.Length; i++)
   
   if(arr[i] >= min &&  arr[i] <= max)
    {     
      count += 1;
    }
    return count;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, min, max);
ShowArray(array);

int count = Checking(array, 2,5);
Console.WriteLine($"Кол-во элем-ов в данном интервале {count}");
*/
/*
//MyrepozCSDz005.
//Zadacha1.Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
   int[] array = new int[size];
   
   for(int i = 0; i < size; i++)
   array[i] = new Random().Next(minValue, maxValue+1);
   
   return array;
}


void ShowArray(int[] arr)
{
   for(int i = 0; i < arr.Length; i++)
       Console.Write(arr[i] + " ");

   Console.WriteLine();
}

int EvenNumb(int[] arry, int min, int max)
{ 
   int count = 0;

   for(int n = 0; n < arry.Length; n++)
   
   if (arry[n] % 2 == 0)
    {     
      count += 1;
    }
    return count;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, min, max);
ShowArray(array);

int count = EvenNumb(array, min, max);
Console.WriteLine("В массиве чётных чисел " + count);
*/

/*
//2.Zadacha. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
   int[] array = new int[size];
   
   for(int i = 0; i < size; i++)
   array[i] = new Random().Next(minValue, maxValue+1);
   
   return array;
}


void ShowArray(int[] arr)
{
   for(int i = 0; i < arr.Length; i++)
       Console.Write(arr[i] + " ");

   Console.WriteLine();
}

int SumNoEvenNumb(int[] arr, int min, int max)
{ 
   int sum = 0;
   for (int j = 1; j < arr.Length; j+=2)
    sum = sum + arr[j];
    
    return sum;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, min, max);
ShowArray(array);

int sum = SumNoEvenNumb(array, min, max);
Console.WriteLine("В массиве сумма элементов cтоящих на нечётных позициях = " + sum);
*/
/*
//3.Zadacha. Nesmog. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];
CreateRandomArray(array);
ShowArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < array.Length; j++)
{

    if (array[j] > max)
        {
            max = array[j];
        }
    if (array[j] < min)
        {
            min = array[j];
        }
}
Console.WriteLine($" vsego {array.Length} nums, maxim element = {max}, minim element = {min} ");
Console.WriteLine($"Differen = {max - min}");

void CreateRandomArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100 ;
        }
}

void ShowArray(double[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/
//Gotovo!





