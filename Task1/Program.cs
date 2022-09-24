int random = new Random().Next(1, 20);
int[] numbers = new int[random];
int count = 0;
ArrayRandom(numbers);
PrintArray(numbers);
PrintArrayEven(numbers);
Console.WriteLine("> " + count);


void ArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}
void PrintArrayEven(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        if(numbers[j] % 2 == 0)
        {
            // Console.Write(array[j] + " ");
            count++;
        }
        else
        {
            Console.Write("");
        }
    }

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}



