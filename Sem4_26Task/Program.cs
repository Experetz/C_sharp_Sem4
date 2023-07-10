/* Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе. */

int GetDigits (int number)
{
    int count = 1;
    number = Math.Abs(number);

    while (number >= 10)
    {
        number /= 10;
        count++;
    }

    return count;
}    

Console.WriteLine("Please put a number"); 
int usernumber = int.Parse(Console.ReadLine());

int count = GetDigits(usernumber);
Console.WriteLine($"There are {count} digits in your number");



