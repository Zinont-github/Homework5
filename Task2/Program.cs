int random = new Random().Next(3, 11);
int[] numbers = new int[random];
int summa = 0;


ArrayRandom(numbers);
PrintArray(numbers);

for (int i = 1; i < random ; i = i + 2)
{
    summa = summa + numbers[i];
}

Console.Write("   >>>  " + summa);
// Console.Write();

void ArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-30, 30);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
}