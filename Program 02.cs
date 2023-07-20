// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumDigit(int number)

{
    int result = 0;
    int sum = 0;
    int sumTotal = 0;
    while (number > 10)
    {
        result = number % 10;
        number = number / 10;
        sum = sum + result;
    }
    sumTotal = sum + number;
    Console.WriteLine($"Your result is: {sumTotal}");
    return sumTotal;
}
Console.WriteLine("Enter your number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
SumDigit(user_number);