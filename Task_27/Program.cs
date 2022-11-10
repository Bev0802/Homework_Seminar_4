// Задача 27: Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

//Функция, которая принимает чило и выдает сумму цифр.
int SumDigitsNumber(int num)
{
    int sum = 0;
    int result = num;
    while (result > 0)
    {
        sum = (result % 10) + sum;
        result = result / 10;
    }
    return sum;
}

//Получение данных
Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = Math.Abs(number);
}пше 

//Вывод результата
Console.WriteLine($"Сумма цифр: {SumDigitsNumber(number)}");
