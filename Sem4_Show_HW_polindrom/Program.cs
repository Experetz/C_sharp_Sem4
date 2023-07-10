//Решение ДЗ по решению полиндром или нет с помощью разворота числа 
//(КАК ПЕРЕВЕРНУТЬ ЧИСЛО)

//48697 == polindrom?321`

bool IsPalindrome (int usernumber)
{
    {
        if (usernumber < 0 )
        return false;
    }

int revNumber = 0;
int TempMethodNumber = usernumber;
while (TempMethodNumber !=0)
{
    // Крайняя правая цифра исходного числа
    int temp = TempMethodNumber % 10;
    //Формируем новое число 
    revNumber = (revNumber * 10) + temp;

    //Уменьшение исходного числа
    TempMethodNumber = TempMethodNumber / 10;
} 
if (revNumber == usernumber)
    return true;

return false;
}

Console.WriteLine(IsPalindrome(222221));

