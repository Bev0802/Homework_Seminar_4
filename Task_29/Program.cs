// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
//выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

//метод заполнения массива.
void FillArray(int[]arr)
{ 
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,100);
    }
}

//метод вывода массива на печать.
void PritArray(int[]arr)
{ 
   
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i!=arr.Length -1 ) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
Console.WriteLine("]");
}

//Программа

int []array = new int [8];
FillArray(array);
PritArray(array);