//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//Функция возведения в степень (в положительную и в отрецательную).
decimal Exponentiation(int num, int exp)
{
    decimal sum = num;
    decimal res = sum;
    if (exp > 0)
    {
        for (int i = 2; i <= exp; i++)
        {
            sum *= num;
        }
        return sum;
    }
    else
    {
        for (int i = exp; i <= -2; i++)
        {
            sum *= num;
            res = 1 / sum;
        }
        return res;
    }
}
// Получение данных от пользователя
Console.Write("Введите основание степени:");
int number = Convert.ToInt32(Console.ReadLine());
//Проверка на отрицательное.
if (number <= 0)
{
    number = Math.Abs(number);
}
Console.Write("Введите показатель степени:");
int exponent = Convert.ToInt32(Console.ReadLine());

//Вывод результата
Console.Write($"{number}^{exponent} = {Exponentiation(number, exponent)}");
