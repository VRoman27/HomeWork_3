/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

bool isParsed = false;
int num = 0;

while (!isParsed)
{
    Console.Write("Введите число: ");
    isParsed = int.TryParse(Console.ReadLine(), out num);
}

PrintTable(CubeTable(num));


void PrintTable(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] CubeTable(int number)
{
    int[] array = new int[number];

    for (int i = 1; i <= number; i++)
    {
        array[i-1] = (int)Math.Pow((double)i,3);
    }

    return array;
}
