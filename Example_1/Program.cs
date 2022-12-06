/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/

bool isParsed = false;
int num = 0;

while (!isParsed)
{
    Console.Write("Введите число: ");
    isParsed = int.TryParse(Console.ReadLine(), out num);
    if (num > 99999 | num < 10000)
    {
        Console.WriteLine("Нужно пятизначное число!");
        isParsed = false;
    }
}

int InvertDigitPosition(int number)
{
    int newNumber = 0;
    for (int i = 4; i >= 0; i--)
    {
        newNumber = newNumber + (number % 10)*(int)Math.Pow(10,(double)i);
        number /= 10;
    }
    return newNumber;
     
}

void ItsPalindrome(int x)
{
    if(x == InvertDigitPosition(x))
    {
        Console.WriteLine("Это полиндром");
    }
    else
    {
        Console.WriteLine("Это не полиндром");
    }
}

ItsPalindrome(num);
