int random = new Random().Next(5, 10);
int[] numbers = new int[random];


ArrayRandom(numbers);
PrintArray(numbers);

int max = numbers[0];
int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > max)
    {
        max = numbers[i];
    }
    else if(numbers[i] < min)
    {
        min = numbers[i];
    }
}


Console.WriteLine("");
Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Разница между максимальным и минимальным числом:  {max - min}");


void ArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
}