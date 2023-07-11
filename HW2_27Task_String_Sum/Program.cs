/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int RequestNumber(string message)
{
      Console.Write(message);
      string value = Console.ReadLine();  
      int result = Convert.ToInt32(value);
      return result;
}

int usernumber = RequestNumber("Please put a number to summorize   ");
string strnumber = usernumber.ToString();
var sum = 0;

foreach (var number in strnumber)
{
    sum += int.Parse(number.ToString());
}
Console.WriteLine(sum);