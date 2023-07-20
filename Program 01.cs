// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int number, int coef)
{
    int result = number;
    for (int i = 1; i < coef; i++)
    {
        result = result * number;
    }
    Console.WriteLine($"Your result is: {result} ");
    return result;
}
Console.WriteLine("Enter your number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your coef: ");
int my_coef = Convert.ToInt32(Console.ReadLine());
Exponentiation(user_number, my_coef);