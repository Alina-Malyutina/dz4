void FillArray(int [] numbers)
{
    
    Console.WriteLine("This program assepts 8 numbers and made array of them");
    Console.Write("Enter first number: ");
    numbers[0] = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i < numbers.Length; i++)
    {
        Console.Write("Enter next number: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int [] numbers = new int [8];
FillArray(numbers);

Console.Write("[");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]}, ");
}
Console.Write("]");
