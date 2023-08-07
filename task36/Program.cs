/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Write(" Введите размер массива: ");
int size1=int.Parse(Console.ReadLine()!);
int[] massive=GetArray(size1);

Console.WriteLine($"[{String.Join(",", massive)}]");
Console.WriteLine($"Сумма элементов с нечетными индексами в массиве = {OddIndexSum(massive, size1)}");


int OddIndexSum(int[] array, int size){

    int sum=0;
    for (int i=1; i<size; i+=2){

        sum+= array[i];
    }

    return sum;
}


int[] GetArray (int size){

    int[] array=new int[size];

    for(int i=0; i<size; i++) array[i]=new Random().Next();

    return array; 
}