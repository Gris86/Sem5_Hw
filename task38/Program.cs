/* Задача 38: Задайте массив целых чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3, 4, 1, 77, 65] => 77 - 1 = 76 */

Console.Write(" Введите размер массива: ");
int size1=int.Parse(Console.ReadLine()!);
int[] massive=GetArray(size1);

Console.WriteLine($"[{String.Join(",", massive)}]");

int[] newarray=GetMinMax (massive, size1);
Console.WriteLine($"Разница между максимальным {newarray[0]} и минимальным {newarray[1]} элементами массива = {newarray[0]-newarray[1]}");



int[] GetMinMax (int[] array, int size) {

int[] minMax = new int[2];

minMax[0]=array[0]; // max
minMax[1]=array[0]; //min

for(int i=1; i<size; i++){

    if(array[i]>minMax[0]) minMax[0]=array[i];
    if(array[i]<minMax[1]) minMax[1]=array[i];
}
    return minMax;
}


int[] GetArray (int size){

    int[] array=new int[size];

    for(int i=0; i<size; i++) array[i]=new Random().Next(1, 100);

    return array; 
}