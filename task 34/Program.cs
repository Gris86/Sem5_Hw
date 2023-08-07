/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Write(" Введите размер массива: ");
int size1=int.Parse(Console.ReadLine()!);
int[] massive=GetArray(size1);

Console.WriteLine($"[{String.Join(",", massive)}]");
Console.WriteLine($"Количество четных чисел в массиве = {EvenNumbersCount(massive, size1)}");



int EvenNumbersCount(int[] array, int size){

    int count=0;
    for (int i=0; i<size; i++){

        count+= array[i]%2==0 ? 1:0;
    }

    return count;
}



int[] GetArray (int size){

    int[] array=new int[size];

    for(int i=0; i<size; i++) array[i]=new Random().Next(100, 1000);

    return array; 
}