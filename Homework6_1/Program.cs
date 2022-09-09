// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("How many numbers are you planning to enter? ");
int m = Convert.ToInt32(Console.ReadLine());
int [] array = new int[m];

void InputNumbers(int m)
{
    for(int i = 0; i < m; i++)
    {
        Console.Write($"Enter {i+1} number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int Comparison(int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >0) count +=1;
    }
    return count;
}
InputNumbers(m);
Console.WriteLine($"The number of numbers greater than zero is {Comparison(array)}");